namespace VentasAsync
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnBuscar = new Button();
            DgvClientes = new DataGridView();
            BtnAnadirCliente = new Button();
            BtnActualizarCliente = new Button();
            BtnEliminarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvClientes).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(39, 29);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 0;
            BtnBuscar.Text = "buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += button1_Click;
            // 
            // DgvClientes
            // 
            DgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvClientes.Location = new Point(2, 58);
            DgvClientes.Name = "DgvClientes";
            DgvClientes.Size = new Size(796, 235);
            DgvClientes.TabIndex = 1;
            // 
            // BtnAnadirCliente
            // 
            BtnAnadirCliente.Location = new Point(100, 313);
            BtnAnadirCliente.Name = "BtnAnadirCliente";
            BtnAnadirCliente.Size = new Size(75, 23);
            BtnAnadirCliente.TabIndex = 2;
            BtnAnadirCliente.Text = "Añadir";
            BtnAnadirCliente.UseVisualStyleBackColor = true;
            BtnAnadirCliente.Click += BtnAnadirCliente_Click;
            // 
            // BtnActualizarCliente
            // 
            BtnActualizarCliente.Location = new Point(190, 315);
            BtnActualizarCliente.Name = "BtnActualizarCliente";
            BtnActualizarCliente.Size = new Size(75, 23);
            BtnActualizarCliente.TabIndex = 3;
            BtnActualizarCliente.Text = "Actualizar";
            BtnActualizarCliente.UseVisualStyleBackColor = true;
            BtnActualizarCliente.Click += BtnActualizarCliente_Click;
            // 
            // BtnEliminarCliente
            // 
            BtnEliminarCliente.Location = new Point(278, 318);
            BtnEliminarCliente.Name = "BtnEliminarCliente";
            BtnEliminarCliente.Size = new Size(75, 23);
            BtnEliminarCliente.TabIndex = 4;
            BtnEliminarCliente.Text = "Eliminar";
            BtnEliminarCliente.UseVisualStyleBackColor = true;
            BtnEliminarCliente.Click += BtnEliminarCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminarCliente);
            Controls.Add(BtnActualizarCliente);
            Controls.Add(BtnAnadirCliente);
            Controls.Add(DgvClientes);
            Controls.Add(BtnBuscar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBuscar;
        private DataGridView DgvClientes;
        private Button BtnAnadirCliente;
        private Button BtnActualizarCliente;
        private Button BtnEliminarCliente;
    }
}
