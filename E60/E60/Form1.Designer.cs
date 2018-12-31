namespace E60
{
    partial class mainForm
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.tbx_nombre_producto = new System.Windows.Forms.TextBox();
            this.tbx_numero_identificacion_producto = new System.Windows.Forms.TextBox();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.lbl_numero_identificacion_producto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(70, 80);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 50);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // tbx_nombre_producto
            // 
            this.tbx_nombre_producto.Location = new System.Drawing.Point(115, 15);
            this.tbx_nombre_producto.Name = "tbx_nombre_producto";
            this.tbx_nombre_producto.Size = new System.Drawing.Size(100, 22);
            this.tbx_nombre_producto.TabIndex = 1;
            // 
            // tbx_numero_identificacion_producto
            // 
            this.tbx_numero_identificacion_producto.Location = new System.Drawing.Point(115, 45);
            this.tbx_numero_identificacion_producto.Name = "tbx_numero_identificacion_producto";
            this.tbx_numero_identificacion_producto.Size = new System.Drawing.Size(100, 22);
            this.tbx_numero_identificacion_producto.TabIndex = 2;
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Location = new System.Drawing.Point(25, 20);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(64, 17);
            this.lbl_nombre_producto.TabIndex = 3;
            this.lbl_nombre_producto.Text = "producto";
            // 
            // lbl_numero_identificacion_producto
            // 
            this.lbl_numero_identificacion_producto.AutoSize = true;
            this.lbl_numero_identificacion_producto.Location = new System.Drawing.Point(30, 45);
            this.lbl_numero_identificacion_producto.Name = "lbl_numero_identificacion_producto";
            this.lbl_numero_identificacion_producto.Size = new System.Drawing.Size(50, 17);
            this.lbl_numero_identificacion_producto.TabIndex = 4;
            this.lbl_numero_identificacion_producto.Text = "codigo";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lbl_numero_identificacion_producto);
            this.Controls.Add(this.lbl_nombre_producto);
            this.Controls.Add(this.tbx_numero_identificacion_producto);
            this.Controls.Add(this.tbx_nombre_producto);
            this.Controls.Add(this.btn_agregar);
            this.Name = "mainForm";
            this.Text = "E60";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox tbx_nombre_producto;
        private System.Windows.Forms.TextBox tbx_numero_identificacion_producto;
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.Label lbl_numero_identificacion_producto;
    }
}

