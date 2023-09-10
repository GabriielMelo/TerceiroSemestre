namespace Atividade
{
    partial class Exercicio1
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
            btnCalc = new Button();
            label1 = new Label();
            txtIdade = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(205, 121);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "Calcular";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 78);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Insira a idade";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(172, 75);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(108, 23);
            txtIdade.TabIndex = 2;
            txtIdade.KeyPress += txtIdade_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 23);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Sua idade em dias!";
            // 
            // Exercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 205);
            Controls.Add(label2);
            Controls.Add(txtIdade);
            Controls.Add(label1);
            Controls.Add(btnCalc);
            Name = "Exercicio1";
            Text = "Exercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalc;
        private Label label1;
        private TextBox txtIdade;
        private Label label2;
    }
}