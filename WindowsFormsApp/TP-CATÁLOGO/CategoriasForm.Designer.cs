namespace TP_CATÁLOGO
{
    partial class CategoriasForm
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
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnAgregarCategoría = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblCategorias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategoria.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificarCategoria.Location = new System.Drawing.Point(382, 355);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(184, 42);
            this.btnModificarCategoria.TabIndex = 33;
            this.btnModificarCategoria.Text = "Modificar categoría";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminarCategoria.FlatAppearance.BorderSize = 2;
            this.btnEliminarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(597, 354);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(184, 42);
            this.btnEliminarCategoria.TabIndex = 32;
            this.btnEliminarCategoria.Text = "Eliminar categoría";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(382, 156);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.Size = new System.Drawing.Size(399, 177);
            this.dgvCategorias.TabIndex = 31;
            // 
            // btnAgregarCategoría
            // 
            this.btnAgregarCategoría.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarCategoría.FlatAppearance.BorderSize = 2;
            this.btnAgregarCategoría.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoría.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoría.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCategoría.Location = new System.Drawing.Point(490, 436);
            this.btnAgregarCategoría.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCategoría.Name = "btnAgregarCategoría";
            this.btnAgregarCategoría.Size = new System.Drawing.Size(191, 62);
            this.btnAgregarCategoría.TabIndex = 30;
            this.btnAgregarCategoría.Text = "Agregar categoría";
            this.btnAgregarCategoría.UseVisualStyleBackColor = true;
            this.btnAgregarCategoría.Click += new System.EventHandler(this.btnAgregarCategoría_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Black;
            this.btnAtras.Location = new System.Drawing.Point(140, 64);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(36, 31);
            this.btnAtras.TabIndex = 29;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCategorias.Location = new System.Drawing.Point(413, 64);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(184, 43);
            this.lblCategorias.TabIndex = 34;
            this.lblCategorias.Text = "Categorías";
            // 
            // CategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 601);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnAgregarCategoría);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriasForm";
            this.Load += new System.EventHandler(this.CategoriasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnAgregarCategoría;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblCategorias;
    }
}