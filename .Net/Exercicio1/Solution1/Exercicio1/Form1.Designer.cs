namespace Exercicio1
{
    partial class Exercicio
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExercicio1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExercicio2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExercicio3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExercicio1,
            this.mnuExercicio2,
            this.mnuExercicio3,
            this.toolStripSeparator1,
            this.mnuSair});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mnuExercicio1
            // 
            this.mnuExercicio1.Name = "mnuExercicio1";
            this.mnuExercicio1.Size = new System.Drawing.Size(180, 22);
            this.mnuExercicio1.Text = "Exercicio1";
            // 
            // mnuExercicio2
            // 
            this.mnuExercicio2.Name = "mnuExercicio2";
            this.mnuExercicio2.Size = new System.Drawing.Size(180, 22);
            this.mnuExercicio2.Text = "Exercicio2";
            this.mnuExercicio2.Click += new System.EventHandler(this.mnuExercicio2_Click);
            // 
            // mnuExercicio3
            // 
            this.mnuExercicio3.Name = "mnuExercicio3";
            this.mnuExercicio3.Size = new System.Drawing.Size(180, 22);
            this.mnuExercicio3.Text = "Exercicio3";
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
            // Exercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Exercicio";
            this.Text = "Exercicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem mnuExercicio1;
        private ToolStripMenuItem mnuExercicio2;
        private ToolStripMenuItem mnuExercicio3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuSair;
    }
}