namespace VentasAsync
{
    partial class FrmProductos
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
            DgvProductos = new DataGridView();
            BtnBuscarProducto = new Button();
            BtnanadirProducto = new Button();
            BtnActualizarProducto = new Button();
            BtnEliminarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvProductos).BeginInit();
            SuspendLayout();
            // 
            // DgvProductos
            // 
            DgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProductos.Location = new Point(1, 44);
            DgvProductos.Name = "DgvProductos";
            DgvProductos.Size = new Size(798, 244);
            DgvProductos.TabIndex = 0;
            // 
            // BtnBuscarProducto
            // 
            BtnBuscarProducto.Location = new Point(29, 12);
            BtnBuscarProducto.Name = "BtnBuscarProducto";
            BtnBuscarProducto.Size = new Size(75, 23);
            BtnBuscarProducto.TabIndex = 1;
            BtnBuscarProducto.Text = "Buscar";
            BtnBuscarProducto.UseVisualStyleBackColor = true;
            BtnBuscarProducto.Click += BtnBuscarProducto_Click;
            // 
            // BtnanadirProducto
            // 
            BtnanadirProducto.Location = new Point(44, 357);
            BtnanadirProducto.Name = "BtnanadirProducto";
            BtnanadirProducto.Size = new Size(75, 23);
            BtnanadirProducto.TabIndex = 2;
            BtnanadirProducto.Text = "Añadir";
            BtnanadirProducto.UseVisualStyleBackColor = true;
            BtnanadirProducto.Click += BtnanadirProducto_Click;
            // 
            // BtnActualizarProducto
            // 
            BtnActualizarProducto.Location = new Point(151, 357);
            BtnActualizarProducto.Name = "BtnActualizarProducto";
            BtnActualizarProducto.Size = new Size(75, 23);
            BtnActualizarProducto.TabIndex = 3;
            BtnActualizarProducto.Text = "Actualizar";
            BtnActualizarProducto.UseVisualStyleBackColor = true;
            BtnActualizarProducto.Click += BtnActualizarProducto_Click;
            // 
            // BtnEliminarProducto
            // 
            BtnEliminarProducto.Location = new Point(245, 357);
            BtnEliminarProducto.Name = "BtnEliminarProducto";
            BtnEliminarProducto.Size = new Size(75, 23);
            BtnEliminarProducto.TabIndex = 4;
            BtnEliminarProducto.Text = "Eliminar";
            BtnEliminarProducto.UseVisualStyleBackColor = true;
            BtnEliminarProducto.Click += BtnEliminarProducto_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEliminarProducto);
            Controls.Add(BtnActualizarProducto);
            Controls.Add(BtnanadirProducto);
            Controls.Add(BtnBuscarProducto);
            Controls.Add(DgvProductos);
            Name = "FrmProductos";
            Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)DgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvProductos;
        private Button BtnBuscarProducto;
        private Button BtnanadirProducto;
        private Button BtnActualizarProducto;
        private Button BtnEliminarProducto;
    }
}