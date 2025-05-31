using VentasAsync.Model.Commands;
using VentasAsync.Model.Entities;

namespace VentasAsync
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString;
        public Form1()
        {
            InitializeComponent();
            // Inicializamos la cadena de conexión a la base de datos
            _connectionString = "Server=localhost;" +
                "Database=VentasDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteCommands clienteCommands = new ClienteCommands(_connectionString);

                // Asignamos el ID del cliente que queremos buscar
                int clienteId = 1; // Por ejemplo, buscamos el cliente con ID 1

                cliente = await clienteCommands.GetClienteAsync(clienteId); 

                MessageBox.Show($"ID: {cliente.Id}\n" +
                                $"Nombre: {cliente.Nombre}\n" +
                                $"Teléfono: {cliente.Telefono}\n" +
                                $"Domicilio: {cliente.Domicilio}",
                                "Información del Cliente",
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
