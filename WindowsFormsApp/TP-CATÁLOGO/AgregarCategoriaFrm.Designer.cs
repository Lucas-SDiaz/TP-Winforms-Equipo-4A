namespace TP_CATÁLOGO
{
    partial class AgregarCategoriaFrm
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
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.txtAgregarCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblAgregueNuevaCat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.AutoSize = true;
            this.lblAgregarCategoria.Location = new System.Drawing.Point(35, 85);
            this.lblAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(138, 16);
            this.lblAgregarCategoria.TabIndex = 7;
            this.lblAgregarCategoria.Text = "Nombre de categoría:";
            // 
            // txtAgregarCategoria
            // 
            this.txtAgregarCategoria.Location = new System.Drawing.Point(213, 85);
            this.txtAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAgregarCategoria.Name = "txtAgregarCategoria";
            this.txtAgregarCategoria.Size = new System.Drawing.Size(264, 22);
            this.txtAgregarCategoria.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(323, 135);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 33);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.LightGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(213, 135);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblAgregueNuevaCat
            // 
            this.lblAgregueNuevaCat.AutoSize = true;
            this.lblAgregueNuevaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregueNuevaCat.Location = new System.Drawing.Point(40, 30);
            this.lblAgregueNuevaCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregueNuevaCat.Name = "lblAgregueNuevaCat";
            this.lblAgregueNuevaCat.Size = new System.Drawing.Size(287, 24);
            this.lblAgregueNuevaCat.TabIndex = 8;
            this.lblAgregueNuevaCat.Text = "Agregue una nueva categoría";
            // 
            // AgregarCategoriaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(555, 230);
            this.Controls.Add(this.lblAgregueNuevaCat);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Controls.Add(this.txtAgregarCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarCategoriaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgregarCategoriaFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.TextBox txtAgregarCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblAgregueNuevaCat;
    }
}