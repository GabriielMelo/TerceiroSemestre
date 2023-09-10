namespace Atividade
{
    partial class TelaInicial
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
            menuStrip1 = new MenuStrip();
            exerciciosToolStripMenuItem = new ToolStripMenuItem();
            mnuEx1 = new ToolStripMenuItem();
            mnuEx2 = new ToolStripMenuItem();
            mnuEx3 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exerciciosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // exerciciosToolStripMenuItem
            // 
            exerciciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuEx1, mnuEx2, mnuEx3, toolStripSeparator1, mnuSair });
            exerciciosToolStripMenuItem.Name = "exerciciosToolStripMenuItem";
            exerciciosToolStripMenuItem.Size = new Size(71, 20);
            exerciciosToolStripMenuItem.Text = "Exercicios";
            // 
            // mnuEx1
            // 
            mnuEx1.Name = "mnuEx1";
            mnuEx1.Size = new Size(180, 22);
            mnuEx1.Text = "Exercicio 1";
            mnuEx1.Click += mnuEx1_Click;
            // 
            // mnuEx2
            // 
            mnuEx2.Name = "mnuEx2";
            mnuEx2.Size = new Size(180, 22);
            mnuEx2.Text = "Exercicio 2";
            mnuEx2.Click += mnuEx2_Click;
            // 
            // mnuEx3
            // 
            mnuEx3.Name = "mnuEx3";
            mnuEx3.Size = new Size(180, 22);
            mnuEx3.Text = "Exercicio 3";
            mnuEx3.Click += mnuEx3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // mnuSair
            // 
            mnuSair.Name = "mnuSair";
            mnuSair.Size = new Size(180, 22);
            mnuSair.Text = "Sair";
            mnuSair.Click += mnuSair_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "TelaInicial";
            Text = "Tela Inicial";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem exerciciosToolStripMenuItem;
        private ToolStripMenuItem mnuEx1;
        private ToolStripMenuItem mnuEx2;
        private ToolStripMenuItem mnuEx3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuSair;
    }
}