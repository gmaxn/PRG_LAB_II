namespace Multiple_Document_Interface
{
    partial class FormTestDelegados
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
            this.tbx_mostrar = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_buscarFoto = new System.Windows.Forms.Button();
            this.openFieleDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbx_mostrar
            // 
            this.tbx_mostrar.Location = new System.Drawing.Point(6, 5);
            this.tbx_mostrar.Name = "tbx_mostrar";
            this.tbx_mostrar.Size = new System.Drawing.Size(204, 22);
            this.tbx_mostrar.TabIndex = 0;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(5, 30);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 25);
            this.btn_actualizar.TabIndex = 1;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_buscarFoto
            // 
            this.btn_buscarFoto.Location = new System.Drawing.Point(110, 30);
            this.btn_buscarFoto.Name = "btn_buscarFoto";
            this.btn_buscarFoto.Size = new System.Drawing.Size(100, 25);
            this.btn_buscarFoto.TabIndex = 2;
            this.btn_buscarFoto.Text = "Buscar Foto";
            this.btn_buscarFoto.UseVisualStyleBackColor = true;
            this.btn_buscarFoto.Click += new System.EventHandler(this.btn_buscarFoto_Click);
            // 
            // openFieleDialog
            // 
            this.openFieleDialog.FileName = "openFileDialog";
            // 
            // FormTestDelegados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 63);
            this.Controls.Add(this.btn_buscarFoto);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.tbx_mostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTestDelegados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTestDelegados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_mostrar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_buscarFoto;
        private System.Windows.Forms.OpenFileDialog openFieleDialog;
    }
}