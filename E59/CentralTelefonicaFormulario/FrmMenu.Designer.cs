namespace CentralTelefonicaFormulario
{
    partial class FrmMenu
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_FacturacionLocal = new System.Windows.Forms.Button();
            this.btn_FacturacionProvincial = new System.Windows.Forms.Button();
            this.btn_FacturacionTotal = new System.Windows.Forms.Button();
            this.btn_GenerarLLamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(5, 285);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(270, 65);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_FacturacionLocal
            // 
            this.btn_FacturacionLocal.Location = new System.Drawing.Point(5, 145);
            this.btn_FacturacionLocal.Margin = new System.Windows.Forms.Padding(5);
            this.btn_FacturacionLocal.Name = "btn_FacturacionLocal";
            this.btn_FacturacionLocal.Size = new System.Drawing.Size(270, 65);
            this.btn_FacturacionLocal.TabIndex = 8;
            this.btn_FacturacionLocal.Text = "Facturacion Local";
            this.btn_FacturacionLocal.UseVisualStyleBackColor = true;
            this.btn_FacturacionLocal.Click += new System.EventHandler(this.btn_FacturacionLocal_Click);
            // 
            // btn_FacturacionProvincial
            // 
            this.btn_FacturacionProvincial.Location = new System.Drawing.Point(5, 215);
            this.btn_FacturacionProvincial.Margin = new System.Windows.Forms.Padding(5);
            this.btn_FacturacionProvincial.Name = "btn_FacturacionProvincial";
            this.btn_FacturacionProvincial.Size = new System.Drawing.Size(270, 65);
            this.btn_FacturacionProvincial.TabIndex = 7;
            this.btn_FacturacionProvincial.Text = "Facturacion Provincial";
            this.btn_FacturacionProvincial.UseVisualStyleBackColor = true;
            this.btn_FacturacionProvincial.Click += new System.EventHandler(this.btn_FacturacionProvincial_Click);
            // 
            // btn_FacturacionTotal
            // 
            this.btn_FacturacionTotal.Location = new System.Drawing.Point(5, 75);
            this.btn_FacturacionTotal.Margin = new System.Windows.Forms.Padding(5);
            this.btn_FacturacionTotal.Name = "btn_FacturacionTotal";
            this.btn_FacturacionTotal.Size = new System.Drawing.Size(270, 65);
            this.btn_FacturacionTotal.TabIndex = 6;
            this.btn_FacturacionTotal.Text = "Facturacion Total";
            this.btn_FacturacionTotal.UseVisualStyleBackColor = true;
            this.btn_FacturacionTotal.Click += new System.EventHandler(this.btn_FacturacionTotal_Click);
            // 
            // btn_GenerarLLamada
            // 
            this.btn_GenerarLLamada.Location = new System.Drawing.Point(5, 5);
            this.btn_GenerarLLamada.Margin = new System.Windows.Forms.Padding(5);
            this.btn_GenerarLLamada.Name = "btn_GenerarLLamada";
            this.btn_GenerarLLamada.Size = new System.Drawing.Size(270, 65);
            this.btn_GenerarLLamada.TabIndex = 5;
            this.btn_GenerarLLamada.Text = "Generar LLamada";
            this.btn_GenerarLLamada.UseVisualStyleBackColor = true;
            this.btn_GenerarLLamada.Click += new System.EventHandler(this.btn_GenerarLLamada_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 356);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_FacturacionLocal);
            this.Controls.Add(this.btn_FacturacionProvincial);
            this.Controls.Add(this.btn_FacturacionTotal);
            this.Controls.Add(this.btn_GenerarLLamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_FacturacionLocal;
        private System.Windows.Forms.Button btn_FacturacionProvincial;
        private System.Windows.Forms.Button btn_FacturacionTotal;
        private System.Windows.Forms.Button btn_GenerarLLamada;
    }
}