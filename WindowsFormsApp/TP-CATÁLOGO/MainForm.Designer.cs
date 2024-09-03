namespace TP_CATÁLOGO
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.lblGestionARticulos = new System.Windows.Forms.Label();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.BorderSize = 2;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Location = new System.Drawing.Point(997, 33);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 34);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMarcas.FlatAppearance.BorderSize = 2;
            this.btnMarcas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMarcas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMarcas.Location = new System.Drawing.Point(64, 424);
            this.btnMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(236, 47);
            this.btnMarcas.TabIndex = 16;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCategorias.FlatAppearance.BorderSize = 2;
            this.btnCategorias.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCategorias.Location = new System.Drawing.Point(64, 359);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(236, 47);
            this.btnCategorias.TabIndex = 15;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // lblGestionARticulos
            // 
            this.lblGestionARticulos.AutoSize = true;
            this.lblGestionARticulos.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionARticulos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblGestionARticulos.Location = new System.Drawing.Point(335, 78);
            this.lblGestionARticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionARticulos.Name = "lblGestionARticulos";
            this.lblGestionARticulos.Size = new System.Drawing.Size(347, 43);
            this.lblGestionARticulos.TabIndex = 14;
            this.lblGestionARticulos.Text = "Catálogo de artículos";
            // 
            // btnArticulos
            // 
            this.btnArticulos.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnArticulos.FlatAppearance.BorderSize = 2;
            this.btnArticulos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnArticulos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnArticulos.Location = new System.Drawing.Point(64, 178);
            this.btnArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(236, 47);
            this.btnArticulos.TabIndex = 13;
            this.btnArticulos.Text = "Artículos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.lblGestionARticulos);
            this.Controls.Add(this.btnArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Label lblGestionARticulos;
        private System.Windows.Forms.Button btnArticulos;
    }
}

