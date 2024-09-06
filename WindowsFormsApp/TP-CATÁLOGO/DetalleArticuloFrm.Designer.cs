namespace TP_CATÁLOGO
{
    partial class DetalleArticuloFrm
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
            this.pbxImagenesArticulo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnImgAnterior = new System.Windows.Forms.Button();
            this.btnImgSiguiente = new System.Windows.Forms.Button();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcionArt = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenesArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagenesArticulo
            // 
            this.pbxImagenesArticulo.Location = new System.Drawing.Point(433, 83);
            this.pbxImagenesArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxImagenesArticulo.Name = "pbxImagenesArticulo";
            this.pbxImagenesArticulo.Size = new System.Drawing.Size(275, 275);
            this.pbxImagenesArticulo.TabIndex = 0;
            this.pbxImagenesArticulo.TabStop = false;
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
            this.btnCerrar.Location = new System.Drawing.Point(756, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(55, 42);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnImgAnterior
            // 
            this.btnImgAnterior.Location = new System.Drawing.Point(433, 383);
            this.btnImgAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImgAnterior.Name = "btnImgAnterior";
            this.btnImgAnterior.Size = new System.Drawing.Size(110, 35);
            this.btnImgAnterior.TabIndex = 19;
            this.btnImgAnterior.Text = "anterior";
            this.btnImgAnterior.UseVisualStyleBackColor = true;
            // 
            // btnImgSiguiente
            // 
            this.btnImgSiguiente.Location = new System.Drawing.Point(598, 383);
            this.btnImgSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImgSiguiente.Name = "btnImgSiguiente";
            this.btnImgSiguiente.Size = new System.Drawing.Size(110, 35);
            this.btnImgSiguiente.TabIndex = 20;
            this.btnImgSiguiente.Text = "siguiente";
            this.btnImgSiguiente.UseVisualStyleBackColor = true;
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(13, 96);
            this.lblCodigoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(164, 22);
            this.lblCodigoArticulo.TabIndex = 21;
            this.lblCodigoArticulo.Text = "Código de artículo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 156);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 22);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcionArt
            // 
            this.lblDescripcionArt.AutoSize = true;
            this.lblDescripcionArt.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionArt.Location = new System.Drawing.Point(13, 276);
            this.lblDescripcionArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionArt.Name = "lblDescripcionArt";
            this.lblDescripcionArt.Size = new System.Drawing.Size(108, 22);
            this.lblDescripcionArt.TabIndex = 23;
            this.lblDescripcionArt.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(13, 216);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(64, 22);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(429, 445);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(69, 22);
            this.lblPrecio.TabIndex = 25;
            this.lblPrecio.Text = "Precio: ";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(13, 336);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(93, 22);
            this.lblCategoria.TabIndex = 26;
            this.lblCategoria.Text = "Categoría:";
            // 
            // DetalleArticuloFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcionArt);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Controls.Add(this.btnImgSiguiente);
            this.Controls.Add(this.btnImgAnterior);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbxImagenesArticulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetalleArticuloFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DetalleArticuloFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenesArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagenesArticulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnImgAnterior;
        private System.Windows.Forms.Button btnImgSiguiente;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcionArt;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
    }
}