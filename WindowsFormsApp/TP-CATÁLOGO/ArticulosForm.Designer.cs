namespace TP_CATÁLOGO
{
    partial class ArticulosForm
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
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregarArticulos.FlatAppearance.BorderSize = 2;
            this.btnAgregarArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulos.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulos.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarArticulos.Location = new System.Drawing.Point(469, 486);
            this.btnAgregarArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(259, 37);
            this.btnAgregarArticulos.TabIndex = 21;
            this.btnAgregarArticulos.Text = "Agregar nuevo artículo";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.btnAgregarArticulos_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Black;
            this.btnAtras.Location = new System.Drawing.Point(136, 54);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(36, 31);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificarArticulo.Location = new System.Drawing.Point(509, 398);
            this.btnModificarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(179, 43);
            this.btnModificarArticulo.TabIndex = 18;
            this.btnModificarArticulo.Text = "Modificar Artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminarArticulo.FlatAppearance.BorderSize = 2;
            this.btnEliminarArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(725, 396);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(179, 43);
            this.btnEliminarArticulo.TabIndex = 17;
            this.btnEliminarArticulo.Text = "Eliminar Artículo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerDetalle.Location = new System.Drawing.Point(296, 396);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(179, 43);
            this.btnVerDetalle.TabIndex = 16;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(296, 187);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(609, 177);
            this.dgvArticulos.TabIndex = 15;
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblArticulos.Location = new System.Drawing.Point(421, 54);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(157, 43);
            this.lblArticulos.TabIndex = 35;
            this.lblArticulos.Text = "Artículos";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(352, 135);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(49, 16);
            this.lblBuscar.TabIndex = 36;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(453, 135);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(292, 22);
            this.txtFiltro.TabIndex = 37;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(75, 190);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 38;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(76, 241);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 39;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(89, 289);
            this.lblFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(36, 16);
            this.lblFiltroAvanzado.TabIndex = 40;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(133, 187);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(132, 24);
            this.cboCampo.TabIndex = 41;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(133, 238);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(132, 24);
            this.cboCriterio.TabIndex = 42;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(133, 286);
            this.txtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(132, 22);
            this.txtFiltroAvanzado.TabIndex = 43;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(136, 336);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 601);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblArticulos);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 601);
            this.MinimumSize = new System.Drawing.Size(1100, 601);
            this.Name = "ArticulosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticulosForm";
            this.Load += new System.EventHandler(this.ArticulosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnBuscar;
    }
}