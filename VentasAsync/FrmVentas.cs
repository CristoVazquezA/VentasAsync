using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasAsync.Model.Commands;
using VentasAsync.Model.Entities;

namespace VentasAsync
{
    public partial class FrmVentas : Form
    {
        private readonly VentaCommands _ventaCommands;

        public FrmVentas()
        {
            InitializeComponent();
            _ventaCommands = new VentaCommands();
            CargarGridVentas();
        }

        private async void CargarGridVentas()
        {
            try
            {
                DgvVentas.DataSource = await _ventaCommands.GetVentasAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnBuscarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                Venta venta = new Venta();
                VentaCommands ventaCommands = new VentaCommands();

                // Asignamos el ID del cliente que queremos buscar
                int ventaId = 1; // Por ejemplo, buscamos el cliente con ID 1

                venta = await ventaCommands.GetVentaAsync(ventaId);

                if (venta == null)
                {
                    MessageBox.Show("venta no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Fecha: {venta.Fecha}\n" +
                                $"Folio: {venta.Folio}\n" +
                                $"Total: {venta.Total}\n" +
                                $"Cliente: {venta.ClienteID}",
                                "Información de la venta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnAnadirventa_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            ProductoCommands ProductoCommands = new ProductoCommands();

            try
            {
                // Asignamos el ID del cliente que queremos añadir
                int VentaId = 2; // Por ejemplo, añadimos un cliente con ID 2
                venta = await VentaCommands.AddVentaAsync();
                if (venta == null)
                {
                    MessageBox.Show("No se pudo añadir la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Venta realizada:\n" +
                                $"Fecha: {venta.Fecha}\n" +
                                $"Folio: {venta.Folio}\n" +
                                $"Total: {venta.Total}\n" +
                                $"ClienteId: {venta.ClienteID}",
                                "Venta realizada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnActualizarVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            VentaCommands ventaCommands = new VentaCommands();
            try
            {
                // Asignamos el ID del cliente que queremos actualizar
                int ventaId = 1; // Por ejemplo, actualizamos el cliente con ID 1
                venta = await ventaCommands.UpdateVentaAsync(ventaId);
                if (venta == null)
                {
                    MessageBox.Show("No se pudo actualizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Venta actualizada:\n" +
                                $"Fecha: {venta.Fecha}\n" +
                                $"Folio: {venta.Folio}\n" +
                                $"Total:  {venta.Total}\n" +
                                $"ClienteId: {venta.ClienteID}",
                                "Venta actualizada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnEliminarVenta_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            VentaCommands ventaCommands = new VentaCommands();
            try
            {
                // Asignamos el ID del cliente que queremos eliminar
                int ventaId = 1; // Por ejemplo, eliminamos el cliente con ID 1
                venta = await ventaCommands.DeleteVentaAsync(ventaId);
                MessageBox.Show($"Venta con ID {ventaId} eliminado correctamente.",
                                "Venta Eliminada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
