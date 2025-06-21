namespace VentasAsync
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgvVentas = new DataGridView();
            BtnBuscarVenta = new Button();
            BtnAnadirventa = new Button();
            BtnActualizarVenta = new Button();
            BtnEliminarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvVentas).BeginInit();
            SuspendLayout();
            // 
            // DgvVentas
            // 
            DgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvVentas.Location = new Point(2, 105);
            DgvVentas.Name = "DgvVentas";
            DgvVentas.Size = new Size(796, 230);
            DgvVentas.TabIndex = 0;
            // 
            // BtnBuscarVenta
            // 
            BtnBuscarVenta.Location = new Point(47, 37);
            BtnBuscarVenta.Name = "BtnBuscarVenta";
            BtnBuscarVenta.Size = new Size(75, 23);
            BtnBuscarVenta.TabIndex = 1;
            BtnBuscarVenta.Text = "Buscar";
            BtnBuscarVenta.UseVisualStyleBackColor = true;
            BtnBuscarVenta.Click += BtnBuscarVenta_Click;
            // 
            // BtnAnadirventa
            // 
            BtnAnadirventa.Location = new Point(47, 372);
            BtnAnadirventa.Name = "BtnAnadirventa";
            BtnAnadirventa.Size = new Size(75, 23);
            BtnAnadirventa.TabIndex = 2;
            BtnAnadirventa.Text = "Añadir";
            BtnAnadirventa.UseVisualStyleBackColor = true;
            BtnAnadirventa.Click += BtnAnadirventa_Click;
            // 
            // BtnActualizarVenta
            // 
            BtnActualizarVenta.Location = new Point(152, 372);
            BtnActualizarVenta.Name = "BtnActualizarVenta";
            BtnActualizarVenta.Size = new Size(75, 23);
            BtnActualizarVenta.TabIndex = 3;
            BtnActualizarVenta.Text = "Actualizar";
            BtnActualizarVenta.UseVisualStyleBackColor = true;
            BtnActualizarVenta.Click += BtnActualizarVenta_Click;
            // 
            // BtnEliminarVenta
            // 
            BtnEliminarVenta.Location = new Point(253, 372);
            BtnEliminarVenta.Name = "BtnEliminarVenta";
            BtnEliminarVenta.Size = new Size(75, 23);
            BtnEliminarVenta.TabIndex = 4;
            BtnEliminarVenta.Text = "Eliminar";
            BtnEliminarVenta.UseVisualStyleBackColor = true;
            BtnEliminarVenta.Click += BtnEliminarVenta_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminarVenta);
            Controls.Add(BtnActualizarVenta);
            Controls.Add(BtnAnadirventa);
            Controls.Add(BtnBuscarVenta);
            Controls.Add(DgvVentas);
            Name = "FrmVentas";
            Text = "FrmVentas";
            ((System.ComponentModel.ISupportInitialize)DgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvVentas;
        private Button BtnBuscarVenta;
        private Button BtnAnadirventa;
        private Button BtnActualizarVenta;
        private Button BtnEliminarVenta;
    }
}