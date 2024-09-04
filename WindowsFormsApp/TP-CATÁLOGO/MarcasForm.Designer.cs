namespace TP_CATÁLOGO
{
    partial class MarcasForm
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.lblMarcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Black;
            this.btnAtras.Location = new System.Drawing.Point(103, 52);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(27, 25);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarMarca.FlatAppearance.BorderSize = 2;
            this.btnAgregarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarMarca.Location = new System.Drawing.Point(519, 367);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(143, 50);
            this.btnAgregarMarca.TabIndex = 24;
            this.btnAgregarMarca.Text = "Agregar marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(103, 127);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(559, 144);
            this.dgvArticulos.TabIndex = 25;
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarca.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificarMarca.Location = new System.Drawing.Point(103, 301);
            this.btnModificarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(124, 34);
            this.btnModificarMarca.TabIndex = 28;
            this.btnModificarMarca.Text = "Modificar marca";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminarMarca.FlatAppearance.BorderSize = 2;
            this.btnEliminarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarMarca.Location = new System.Drawing.Point(519, 301);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(143, 34);
            this.btnEliminarMarca.TabIndex = 27;
            this.btnEliminarMarca.Text = "Eliminar marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMarcas.Location = new System.Drawing.Point(334, 52);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(107, 34);
            this.lblMarcas.TabIndex = 35;
            this.lblMarcas.Text = "Marcas";
            // 
            // MarcasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnAtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(825, 488);
            this.MinimumSize = new System.Drawing.Size(825, 488);
            this.Name = "MarcasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarcasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Label lblMarcas;
    }
}