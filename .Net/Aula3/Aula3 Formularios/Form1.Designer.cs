namespace Aula3_Formularios
{
    partial class frmAula3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnforeach = new System.Windows.Forms.Button();
            this.lstWhile = new System.Windows.Forms.ListBox();
            this.lstFor = new System.Windows.Forms.ListBox();
            this.lstForeach = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exemplo While";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exemplo For";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exemplo Foreach";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exemplos Aula 3";
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(12, 76);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(129, 23);
            this.btnWhile.TabIndex = 4;
            this.btnWhile.Text = "Executar While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(210, 76);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(126, 23);
            this.btnFor.TabIndex = 5;
            this.btnFor.Text = "Executar For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnforeach
            // 
            this.btnforeach.Location = new System.Drawing.Point(413, 76);
            this.btnforeach.Name = "btnforeach";
            this.btnforeach.Size = new System.Drawing.Size(120, 23);
            this.btnforeach.TabIndex = 6;
            this.btnforeach.Text = "Executar Foreach";
            this.btnforeach.UseVisualStyleBackColor = true;
            this.btnforeach.Click += new System.EventHandler(this.btnforeach_Click);
            // 
            // lstWhile
            // 
            this.lstWhile.FormattingEnabled = true;
            this.lstWhile.ItemHeight = 15;
            this.lstWhile.Location = new System.Drawing.Point(12, 112);
            this.lstWhile.Name = "lstWhile";
            this.lstWhile.Size = new System.Drawing.Size(129, 199);
            this.lstWhile.TabIndex = 7;
            // 
            // lstFor
            // 
            this.lstFor.FormattingEnabled = true;
            this.lstFor.ItemHeight = 15;
            this.lstFor.Location = new System.Drawing.Point(210, 112);
            this.lstFor.Name = "lstFor";
            this.lstFor.Size = new System.Drawing.Size(126, 199);
            this.lstFor.TabIndex = 8;
            // 
            // lstForeach
            // 
            this.lstForeach.FormattingEnabled = true;
            this.lstForeach.ItemHeight = 15;
            this.lstForeach.Location = new System.Drawing.Point(413, 112);
            this.lstForeach.Name = "lstForeach";
            this.lstForeach.Size = new System.Drawing.Size(120, 199);
            this.lstForeach.TabIndex = 9;
            // 
            // frmAula3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 318);
            this.Controls.Add(this.lstForeach);
            this.Controls.Add(this.lstFor);
            this.Controls.Add(this.lstWhile);
            this.Controls.Add(this.btnforeach);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAula3";
            this.Text = "Exemplo Aula 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnWhile;
        private Button btnFor;
        private Button btnforeach;
        private ListBox lstWhile;
        private ListBox lstFor;
        private ListBox lstForeach;
    }
}