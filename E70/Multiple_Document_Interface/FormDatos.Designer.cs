namespace Multiple_Document_Interface
{
    partial class FormDatos
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.pbx_imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(330, 610);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(150, 30);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "nombre";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbx_imagen
            // 
            this.pbx_imagen.Location = new System.Drawing.Point(5, 5);
            this.pbx_imagen.Name = "pbx_imagen";
            this.pbx_imagen.Size = new System.Drawing.Size(800, 600);
            this.pbx_imagen.TabIndex = 1;
            this.pbx_imagen.TabStop = false;
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 646);
            this.Controls.Add(this.pbx_imagen);
            this.Controls.Add(this.lbl_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatos";
            this.Text = "FormDatos";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.PictureBox pbx_imagen;
    }
}