namespace Exercicios
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
            this.exerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exerciciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEx1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEx2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEx3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciciosToolStripMenuItem,
            this.exerciciosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exerciciosToolStripMenuItem
            // 
            this.exerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio1ToolStripMenuItem,
            this.exercicio2ToolStripMenuItem,
            this.exercicio3ToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            this.exerciciosToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // exercicio1ToolStripMenuItem
            // 
            this.exercicio1ToolStripMenuItem.Name = "exercicio1ToolStripMenuItem";
            this.exercicio1ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exercicio1ToolStripMenuItem.Text = "Exercicio1";
            // 
            // exercicio2ToolStripMenuItem
            // 
            this.exercicio2ToolStripMenuItem.Name = "exercicio2ToolStripMenuItem";
            this.exercicio2ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exercicio2ToolStripMenuItem.Text = "Exercicio2";
            // 
            // exercicio3ToolStripMenuItem
            // 
            this.exercicio3ToolStripMenuItem.Name = "exercicio3ToolStripMenuItem";
            this.exercicio3ToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exercicio3ToolStripMenuItem.Text = "Exercicio3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(124, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // exerciciosToolStripMenuItem1
            // 
            this.exerciciosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEx1,
            this.mnuEx2,
            this.mnuEx3,
            this.toolStripSeparator2,
            this.mnuSair});
            this.exerciciosToolStripMenuItem1.Name = "exerciciosToolStripMenuItem1";
            this.exerciciosToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.exerciciosToolStripMenuItem1.Text = "Exercicios";
            // 
            // mnuEx1
            // 
            this.mnuEx1.Name = "mnuEx1";
            this.mnuEx1.Size = new System.Drawing.Size(180, 22);
            this.mnuEx1.Text = "Exercicio1";
            this.mnuEx1.Click += new System.EventHandler(this.mnuEx1_Click);
            // 
            // mnuEx2
            // 
            this.mnuEx2.Name = "mnuEx2";
            this.mnuEx2.Size = new System.Drawing.Size(180, 22);
            this.mnuEx2.Text = "Exercicio2";
            this.mnuEx2.Click += new System.EventHandler(this.mnuEx2_Click);
            // 
            // mnuEx3
            // 
            this.mnuEx3.Name = "mnuEx3";
            this.mnuEx3.Size = new System.Drawing.Size(180, 22);
            this.mnuEx3.Text = "Exercicio3";
            this.mnuEx3.Click += new System.EventHandler(this.mnuEx3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(180, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 301);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Exercicios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exerciciosToolStripMenuItem;
        private ToolStripMenuItem exercicio1ToolStripMenuItem;
        private ToolStripMenuItem exercicio2ToolStripMenuItem;
        private ToolStripMenuItem exercicio3ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem exerciciosToolStripMenuItem1;
        private ToolStripMenuItem mnuEx1;
        private ToolStripMenuItem mnuEx2;
        private ToolStripMenuItem mnuEx3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuSair;
    }
}