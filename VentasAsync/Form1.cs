using Microsoft.Data.SqlClient;
using System.Data;
using VentasAsync.Model.Commands;
using VentasAsync.Model.Entities;

namespace VentasAsync
{
    public partial class Form1 : Form
    {

        private readonly ClienteCommands _clienteCommands;
        public Form1()
        {
            InitializeComponent();
            _clienteCommands = new ClienteCommands();
            CargarGridClientes();

            // Inicializamos la cadena de conexión a la base de datos

        }
        private async void CargarGridClientes()
        {
            try
            {
                DgvClientes.DataSource = await _clienteCommands.GetClientesAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /*private void CargarGridClientes()
        {
            try
            {
                DgvClientes.DataSource = null;

                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "SELECT  Id,Nombre,Telefono,Domicilio FROM Clientes";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable dtClientes = new DataTable();
                        adapter.Fill(dtClientes);

                        DgvClientes.DataSource = dtClientes;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }*/
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteCommands clienteCommands = new ClienteCommands();

                // Asignamos el ID del cliente que queremos buscar
                int clienteId = 1; // Por ejemplo, buscamos el cliente con ID 1

                cliente = await clienteCommands.GetClienteAsync(clienteId);

                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

        private async void BtnAnadirCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteCommands clienteCommands = new ClienteCommands();

            try
            {
                // Asignamos el ID del cliente que queremos añadir
                int clienteId = 2; // Por ejemplo, añadimos un cliente con ID 2
                cliente = await clienteCommands.AddClienteAsync();
                if (cliente == null)
                {
                    MessageBox.Show("No se pudo añadir el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Cliente añadido:\n" +
                                $"ID: {cliente.Id}\n" +
                                $"Nombre: {cliente.Nombre}\n" +
                                $"Teléfono: {cliente.Telefono}\n" +
                                $"Domicilio: {cliente.Domicilio}",
                                "Cliente Añadido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnActualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteCommands clienteCommands = new ClienteCommands();
            try
            {
                // Asignamos el ID del cliente que queremos actualizar
                int clienteId = 1; // Por ejemplo, actualizamos el cliente con ID 1
                cliente = await clienteCommands.UpdateClienteAsync(clienteId);
                if (cliente == null)
                {
                    MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Cliente actualizado:\n" +
                                $"ID: {cliente.Id}\n" +
                                $"Nombre: {cliente.Nombre}\n" +
                                $"Teléfono: {cliente.Telefono}\n" +
                                $"Domicilio: {cliente.Domicilio}",
                                "Cliente Actualizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteCommands clienteCommands = new ClienteCommands();
            try
            {
                // Asignamos el ID del cliente que queremos eliminar
                int clienteId = 1; // Por ejemplo, eliminamos el cliente con ID 1
                cliente = await clienteCommands.DeleteClienteAsync(clienteId);
                MessageBox.Show($"Cliente con ID {clienteId} eliminado correctamente.",
                                "Cliente Eliminado",
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
