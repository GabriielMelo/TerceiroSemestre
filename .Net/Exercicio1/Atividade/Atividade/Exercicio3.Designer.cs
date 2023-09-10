namespace Atividade
{
    partial class Exercicio3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNomes = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            btnCalcular = new Button();
            btnAdd = new Button();
            label4 = new Label();
            label5 = new Label();
            txtResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 76);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Nota 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 143);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota 2:";
            // 
            // txtNomes
            // 
            txtNomes.Location = new Point(76, 73);
            txtNomes.Name = "txtNomes";
            txtNomes.Size = new Size(146, 23);
            txtNomes.TabIndex = 3;
            txtNomes.KeyPress += txtNomes_KeyPress;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(76, 107);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(146, 23);
            txtNota1.TabIndex = 4;
            txtNota1.KeyPress += txtNota1_KeyPress;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(76, 140);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(146, 23);
            txtNota2.TabIndex = 5;
            txtNota2.KeyPress += txtNota2_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(249, 184);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 34);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(65, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 29);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 8;
            label4.Text = "Calcule a média dos alunos!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 73);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 9;
            label5.Text = "Alunos adicionados";
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(292, 98);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(25, 30);
            txtResult.TabIndex = 10;
            txtResult.Text = "0";
            // 
            // Exercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 269);
            Controls.Add(txtResult);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(btnCalcular);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtNomes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Exercicio3";
            Text = "Exercicio3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomes;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private Button btnCalcular;
        private Button btnAdd;
        private Label label4;
        private Label label5;
        private Label txtResult;
    }
}