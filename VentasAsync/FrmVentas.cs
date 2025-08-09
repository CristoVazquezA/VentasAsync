using VentasAsync.Model.Commands;
using VentasAsync.Model.Entities;

namespace VentasAsync
{
    public partial class FrmVentas : Form
    {
        private readonly VentaCommands _ventaCommands;
        private Venta ventaDemo;
        public FrmVentas()
        {
            InitializeComponent();
            _ventaCommands = new VentaCommands();

            VentaDetalle concepto1 = new VentaDetalle
            {
                Renglon = 1,
                ProductoId = 2,
                Cantidad = 1,
                ValorUnitario = 50.00,
                Descripcion = "papitas",
                Importe = 50.00,
            };

            VentaDetalle concepto2 = new VentaDetalle
            {
                Renglon = 2,
                ProductoId = 1,
                Cantidad = 2,
                ValorUnitario = 20.00,
                Descripcion = "soda",
                Importe = 40.00,
            };

            List<VentaDetalle> conceptos = new List<VentaDetalle>
            {
                concepto1,
                concepto2
            };

            ventaDemo = new Venta
            {
                ClienteID = 1,
                Folio = DateTime.Now.Second,
                Total = 90.00,
                Conceptos = conceptos,
            };
        }

        private async void BtnGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                await _ventaCommands.SaveVentaAsync(ventaDemo);
                MessageBox.Show("Venta Guardada Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnGuardarVentaTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                await _ventaCommands.SaveVentaTransactionAsync(ventaDemo);
                MessageBox.Show("Venta Guardada Correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
