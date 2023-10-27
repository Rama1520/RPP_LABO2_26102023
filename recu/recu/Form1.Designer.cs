namespace recu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstVehiculos = new System.Windows.Forms.ListBox();
            lblTipo = new System.Windows.Forms.Label();
            btnFabricar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            cmbTipo = new System.Windows.Forms.ComboBox();
            pcbFabrica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new System.Drawing.Point(12, 13);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new System.Drawing.Size(628, 409);
            lstVehiculos.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new System.Drawing.Point(656, 27);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(94, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de Vehiculo";
            lblTipo.Click += label1_Click;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new System.Drawing.Point(670, 284);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new System.Drawing.Size(107, 48);
            btnFabricar.TabIndex = 2;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(670, 348);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(107, 52);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Automovil", "Camioneta", "Moto" });
            cmbTipo.Location = new System.Drawing.Point(656, 62);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(121, 23);
            cmbTipo.TabIndex = 4;
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = Properties.Resources.icons8_vehicles_64;
            pcbFabrica.Location = new System.Drawing.Point(656, 125);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new System.Drawing.Size(121, 136);
            pcbFabrica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pcbFabrica.TabIndex = 5;
            pcbFabrica.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pcbFabrica);
            Controls.Add(cmbTipo);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(lblTipo);
            Controls.Add(lstVehiculos);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Fabrica de Vehiculos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.PictureBox pcbFabrica;
    }
}
