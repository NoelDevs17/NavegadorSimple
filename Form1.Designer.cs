namespace Navegador
{
    partial class FormNavegador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnFavorito = new System.Windows.Forms.Button();
            this.cmbFavorito = new System.Windows.Forms.ComboBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.txtLink);
            this.panel1.Controls.Add(this.cmbFavorito);
            this.panel1.Controls.Add(this.btnFavorito);
            this.panel1.Controls.Add(this.btnIr);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 89);
            this.panel1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(70, 62);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(599, 12);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(70, 62);
            this.btnIr.TabIndex = 1;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnFavorito
            // 
            this.btnFavorito.AutoSize = true;
            this.btnFavorito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFavorito.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFavorito.Location = new System.Drawing.Point(832, 0);
            this.btnFavorito.Name = "btnFavorito";
            this.btnFavorito.Size = new System.Drawing.Size(105, 89);
            this.btnFavorito.TabIndex = 2;
            this.btnFavorito.Text = "Agregar A Favorito";
            this.btnFavorito.UseVisualStyleBackColor = true;
            this.btnFavorito.Click += new System.EventHandler(this.btnFavorito_Click);
            // 
            // cmbFavorito
            // 
            this.cmbFavorito.FormattingEnabled = true;
            this.cmbFavorito.Location = new System.Drawing.Point(813, 34);
            this.cmbFavorito.Name = "cmbFavorito";
            this.cmbFavorito.Size = new System.Drawing.Size(121, 21);
            this.cmbFavorito.TabIndex = 3;
            this.cmbFavorito.SelectedIndexChanged += new System.EventHandler(this.cmbFavorito_SelectedIndexChanged);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(88, 34);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(505, 20);
            this.txtLink.TabIndex = 4;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 89);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(937, 403);
            this.webBrowser1.TabIndex = 1;
            // 
            // FormNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 492);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "FormNavegador";
            this.Text = "Navegador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.ComboBox cmbFavorito;
        private System.Windows.Forms.Button btnFavorito;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

