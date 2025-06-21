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
    public partial class FrmProductos : Form
    {
        private readonly ProductoCommands _productoCommands;
        public FrmProductos()
        {
            InitializeComponent();
            _productoCommands = new ProductoCommands();
            CargarGridProductos();
        }

        private async void CargarGridProductos()
        {
            try
            {
                DgvProductos.DataSource = await _productoCommands.GetProductosAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();
                ProductoCommands ProductoCommands = new ProductoCommands();

                // Asignamos el ID del cliente que queremos buscar
                int productoId = 1; // Por ejemplo, buscamos el cliente con ID 1

                producto = await ProductoCommands.GetProductoAsync(productoId);

                if (producto == null)
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"ID: {producto.Id}\n" +
                                $"SKU: {producto.SKU}\n" +
                                $"Descripcion: {producto.Descripcion}\n" +
                                $"ValorUnitario: {producto.ValorUnitario}",
                                "Información del Cliente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnanadirProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoCommands ProductoCommands = new ProductoCommands();

            try
            {
                // Asignamos el ID del cliente que queremos añadir
                int productoId = 2; // Por ejemplo, añadimos un cliente con ID 2
                producto = await ProductoCommands.AddProductoAsync();
                if (producto == null)
                {
                    MessageBox.Show("No se pudo añadir el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Producto añadido:\n" +
                                $"ID: {producto.Id}\n" +
                                $"SKU: {producto.SKU}\n" +
                                $"Descripcion: {producto.Descripcion}\n" +
                                $"ValorUnitario: {producto.ValorUnitario}",
                                "Producto Añadido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnActualizarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoCommands productoCommands = new ProductoCommands();
            try
            {
                // Asignamos el ID del cliente que queremos actualizar
                int productoId = 1; // Por ejemplo, actualizamos el cliente con ID 1
                producto = await productoCommands.UpdateProductoAsync(productoId);
                if (producto == null)
                {
                    MessageBox.Show("No se pudo actualizar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Producto actualizado:\n" +
                                $"ID: {producto.Id}\n" +
                                $"SKU: {producto.SKU}\n" +
                                $"Descripcion:  {producto.Descripcion}\n" +
                                $"ValorUnitario: {producto.ValorUnitario}",
                                "Venta actualizada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoCommands productoCommands = new ProductoCommands();
            try
            {
                // Asignamos el ID del cliente que queremos eliminar
                int productoId = 1; // Por ejemplo, eliminamos el cliente con ID 1
                producto = await productoCommands.DeleteProductoAsync(productoId);
                MessageBox.Show($"Producto con ID {productoId} eliminado correctamente.",
                                "Producto Eliminado",
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
