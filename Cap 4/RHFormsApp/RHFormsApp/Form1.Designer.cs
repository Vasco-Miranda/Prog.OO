namespace RHFormsApp
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
            nomeTB = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            salarioTB = new RichTextBox();
            label3 = new Label();
            otherTB = new RichTextBox();
            progBut = new Button();
            gestorBut = new Button();
            salarioBut = new Button();
            outputTB = new RichTextBox();
            SuspendLayout();
            // 
            // nomeTB
            // 
            nomeTB.Location = new Point(174, 80);
            nomeTB.Multiline = false;
            nomeTB.Name = "nomeTB";
            nomeTB.Size = new Size(191, 42);
            nomeTB.TabIndex = 0;
            nomeTB.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 93);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 178);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Salário Base";
            // 
            // salarioTB
            // 
            salarioTB.Location = new Point(174, 165);
            salarioTB.Multiline = false;
            salarioTB.Name = "salarioTB";
            salarioTB.Size = new Size(191, 42);
            salarioTB.TabIndex = 2;
            salarioTB.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 262);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 5;
            label3.Text = "Dado Específico";
            // 
            // otherTB
            // 
            otherTB.Location = new Point(174, 249);
            otherTB.Multiline = false;
            otherTB.Name = "otherTB";
            otherTB.Size = new Size(191, 42);
            otherTB.TabIndex = 4;
            otherTB.Text = "";
            // 
            // progBut
            // 
            progBut.Location = new Point(429, 93);
            progBut.Name = "progBut";
            progBut.Size = new Size(136, 62);
            progBut.TabIndex = 6;
            progBut.Text = "Criar Programador";
            progBut.UseVisualStyleBackColor = true;
            progBut.Click += progBut_Click;
            // 
            // gestorBut
            // 
            gestorBut.Location = new Point(429, 207);
            gestorBut.Name = "gestorBut";
            gestorBut.Size = new Size(136, 62);
            gestorBut.TabIndex = 7;
            gestorBut.Text = "Criar Gestor de Projeto";
            gestorBut.UseVisualStyleBackColor = true;
            gestorBut.Click += gestorBut_Click;
            // 
            // salarioBut
            // 
            salarioBut.Location = new Point(248, 331);
            salarioBut.Name = "salarioBut";
            salarioBut.Size = new Size(145, 64);
            salarioBut.TabIndex = 8;
            salarioBut.Text = "Calcular Salário Líquido";
            salarioBut.UseVisualStyleBackColor = true;
            salarioBut.Click += salarioBut_Click;
            // 
            // outputTB
            // 
            outputTB.Location = new Point(44, 432);
            outputTB.Name = "outputTB";
            outputTB.ReadOnly = true;
            outputTB.Size = new Size(555, 150);
            outputTB.TabIndex = 9;
            outputTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 613);
            Controls.Add(outputTB);
            Controls.Add(salarioBut);
            Controls.Add(gestorBut);
            Controls.Add(progBut);
            Controls.Add(label3);
            Controls.Add(otherTB);
            Controls.Add(label2);
            Controls.Add(salarioTB);
            Controls.Add(label1);
            Controls.Add(nomeTB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox nomeTB;
        private Label label1;
        private Label label2;
        private RichTextBox salarioTB;
        private Label label3;
        private RichTextBox otherTB;
        private Button progBut;
        private Button gestorBut;
        private Button salarioBut;
        private RichTextBox outputTB;
    }
}
