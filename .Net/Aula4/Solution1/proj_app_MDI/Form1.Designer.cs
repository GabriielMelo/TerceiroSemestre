namespace proj_app_MDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.janelaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNovo,
            this.mnuAbrir,
            this.mnuFechar,
            this.toolStripSeparator1,
            this.mnuSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // mnuNovo
            // 
            this.mnuNovo.AccessibleDescription = "";
            this.mnuNovo.Name = "mnuNovo";
            this.mnuNovo.Size = new System.Drawing.Size(180, 22);
            this.mnuNovo.Text = "Novo";
            this.mnuNovo.Click += new System.EventHandler(this.mnuNovo_Click);
            // 
            // mnuAbrir
            // 
            this.mnuAbrir.AccessibleDescription = "";
            this.mnuAbrir.Name = "mnuAbrir";
            this.mnuAbrir.Size = new System.Drawing.Size(180, 22);
            this.mnuAbrir.Text = "Abrir";
            this.mnuAbrir.Click += new System.EventHandler(this.mnuAbrir_Click);
            // 
            // mnuFechar
            // 
            this.mnuFechar.Name = "mnuFechar";
            this.mnuFechar.Size = new System.Drawing.Size(180, 22);
            this.mnuFechar.Text = "Fechar";
            this.mnuFechar.Click += new System.EventHandler(this.mnuFechar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(180, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emCascataToolStripMenuItem,
            this.ladoALadoHorizontalToolStripMenuItem,
            this.ladoALadoVerticalToolStripMenuItem});
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // emCascataToolStripMenuItem
            // 
            this.emCascataToolStripMenuItem.Name = "emCascataToolStripMenuItem";
            this.emCascataToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.emCascataToolStripMenuItem.Text = "Em Cascata";
            this.emCascataToolStripMenuItem.Click += new System.EventHandler(this.emCascataToolStripMenuItem_Click);
            // 
            // ladoALadoHorizontalToolStripMenuItem
            // 
            this.ladoALadoHorizontalToolStripMenuItem.Name = "ladoALadoHorizontalToolStripMenuItem";
            this.ladoALadoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ladoALadoHorizontalToolStripMenuItem.Text = "Lado a Lado Horizontal";
            this.ladoALadoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoHorizontalToolStripMenuItem_Click);
            // 
            // ladoALadoVerticalToolStripMenuItem
            // 
            this.ladoALadoVerticalToolStripMenuItem.Name = "ladoALadoVerticalToolStripMenuItem";
            this.ladoALadoVerticalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.ladoALadoVerticalToolStripMenuItem.Text = "Lado a Lado Vertical";
            this.ladoALadoVerticalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoVerticalToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 344);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Aplicação MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem mnuNovo;
        private ToolStripMenuItem mnuAbrir;
        private ToolStripMenuItem mnuFechar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuSair;
        private ToolStripMenuItem janelaToolStripMenuItem;
        private ToolStripMenuItem emCascataToolStripMenuItem;
        private ToolStripMenuItem ladoALadoHorizontalToolStripMenuItem;
        private ToolStripMenuItem ladoALadoVerticalToolStripMenuItem;
    }
}