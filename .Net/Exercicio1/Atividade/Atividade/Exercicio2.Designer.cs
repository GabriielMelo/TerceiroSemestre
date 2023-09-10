namespace Atividade
{
    partial class Exercicio2
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
            btnCalcular = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtSalario = new TextBox();
            txtFilhos = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtResult = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(326, 218);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(114, 31);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(158, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 95);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 131);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Salario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 170);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Filhos";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(179, 23);
            txtNome.TabIndex = 5;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(93, 128);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(179, 23);
            txtSalario.TabIndex = 6;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // txtFilhos
            // 
            txtFilhos.Location = new Point(93, 167);
            txtFilhos.Name = "txtFilhos";
            txtFilhos.Size = new Size(179, 23);
            txtFilhos.TabIndex = 7;
            txtFilhos.KeyPress += txtFilhos_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 21);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 8;
            label4.Text = "Calcule a Media Salarial!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 93);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 9;
            label5.Text = "Familias Adicionadas";
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(364, 119);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(25, 30);
            txtResult.TabIndex = 11;
            txtResult.Text = "0";
            // 
            // Exercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 338);
            Controls.Add(txtResult);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFilhos);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnCalcular);
            Name = "Exercicio2";
            Text = "Exercicio2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtSalario;
        private TextBox txtFilhos;
        private Label label4;
        private Label label5;
        private Label txtResult;
    }
}