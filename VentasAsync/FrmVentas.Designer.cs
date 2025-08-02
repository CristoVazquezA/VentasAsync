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
            BtnGuardarVenta = new Button();
            SuspendLayout();
            // 
            // BtnGuardarVenta
            // 
            BtnGuardarVenta.Location = new Point(70, 59);
            BtnGuardarVenta.Name = "BtnGuardarVenta";
            BtnGuardarVenta.Size = new Size(129, 23);
            BtnGuardarVenta.TabIndex = 0;
            BtnGuardarVenta.Text = "Guardar venta";
            BtnGuardarVenta.UseVisualStyleBackColor = true;
            BtnGuardarVenta.Click += BtnGuardarVenta_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGuardarVenta);
            Name = "FrmVentas";
            Text = "FrmVentas";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGuardarVenta;
    }
}