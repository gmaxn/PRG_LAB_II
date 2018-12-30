namespace E56
{
    partial class Form1
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
            this.rtb_texto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoCtrlMayúsSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_numberOfChars = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_texto
            // 
            this.rtb_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_texto.Location = new System.Drawing.Point(0, 28);
            this.rtb_texto.Name = "rtb_texto";
            this.rtb_texto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_texto.Size = new System.Drawing.Size(411, 252);
            this.rtb_texto.TabIndex = 0;
            this.rtb_texto.Text = "";
            this.rtb_texto.TextChanged += new System.EventHandler(this.rtb_texto_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarCtrlSToolStripMenuItem,
            this.guardarComoCtrlMayúsSToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.abrirToolStripMenuItem.Text = "Abrir                    Ctrl+A";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarCtrlSToolStripMenuItem
            // 
            this.guardarCtrlSToolStripMenuItem.Name = "guardarCtrlSToolStripMenuItem";
            this.guardarCtrlSToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.guardarCtrlSToolStripMenuItem.Text = "Guardar               Ctrl+S";
            this.guardarCtrlSToolStripMenuItem.Click += new System.EventHandler(this.guardarCtrlSToolStripMenuItem_Click);
            // 
            // guardarComoCtrlMayúsSToolStripMenuItem
            // 
            this.guardarComoCtrlMayúsSToolStripMenuItem.Name = "guardarComoCtrlMayúsSToolStripMenuItem";
            this.guardarComoCtrlMayúsSToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.guardarComoCtrlMayúsSToolStripMenuItem.Text = "Guardar como...  Ctrl+Mayús+S";
            this.guardarComoCtrlMayúsSToolStripMenuItem.Click += new System.EventHandler(this.guardarComoCtrlMayúsSToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_numberOfChars});
            this.statusStrip1.Location = new System.Drawing.Point(0, 258);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(411, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_numberOfChars
            // 
            this.tssl_numberOfChars.Name = "tssl_numberOfChars";
            this.tssl_numberOfChars.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 280);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtb_texto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de Texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_texto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoCtrlMayúsSToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tssl_numberOfChars;
    }
}

