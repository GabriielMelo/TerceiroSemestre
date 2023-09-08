namespace Media
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtSalario = new TextBox();
            txtFilhos = new TextBox();
            btnAdd = new Button();
            btnCalcular = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 56);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 97);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Salario :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 142);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Filhos :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(132, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(120, 23);
            txtNome.TabIndex = 3;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(132, 94);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(120, 23);
            txtSalario.TabIndex = 4;
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // txtFilhos
            // 
            txtFilhos.Location = new Point(132, 139);
            txtFilhos.Name = "txtFilhos";
            txtFilhos.Size = new Size(120, 23);
            txtFilhos.TabIndex = 5;
            txtFilhos.KeyPress += txtFilhos_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(69, 181);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(177, 181);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 20);
            label4.Name = "label4";
            label4.Size = new Size(183, 17);
            label4.TabIndex = 8;
            label4.Text = "Insira os dados de 20 familias";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 241);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(btnAdd);
            Controls.Add(txtFilhos);
            Controls.Add(txtSalario);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Media Familiar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtSalario;
        private TextBox txtFilhos;
        private Button btnAdd;
        private Button btnCalcular;
        private Label label4;
    }
}