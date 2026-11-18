namespace CalculadoraGeometricaFormsApp
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
            calcBut = new Button();
            alturaTB = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            larguraTB = new RichTextBox();
            raioTB = new RichTextBox();
            label3 = new Label();
            logTB = new RichTextBox();
            SuspendLayout();
            // 
            // calcBut
            // 
            calcBut.Location = new Point(321, 233);
            calcBut.Name = "calcBut";
            calcBut.Size = new Size(94, 29);
            calcBut.TabIndex = 0;
            calcBut.Text = "Calcular";
            calcBut.UseVisualStyleBackColor = true;
            calcBut.Click += calcBut_Click;
            // 
            // alturaTB
            // 
            alturaTB.Location = new Point(123, 66);
            alturaTB.Multiline = false;
            alturaTB.Name = "alturaTB";
            alturaTB.Size = new Size(111, 55);
            alturaTB.TabIndex = 1;
            alturaTB.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 83);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 155);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 4;
            label2.Text = "Largura";
            // 
            // larguraTB
            // 
            larguraTB.Location = new Point(123, 138);
            larguraTB.Multiline = false;
            larguraTB.Name = "larguraTB";
            larguraTB.Size = new Size(111, 55);
            larguraTB.TabIndex = 3;
            larguraTB.Text = "";
            // 
            // raioTB
            // 
            raioTB.Location = new Point(509, 105);
            raioTB.Multiline = false;
            raioTB.Name = "raioTB";
            raioTB.Size = new Size(111, 55);
            raioTB.TabIndex = 5;
            raioTB.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 122);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Raio";
            // 
            // logTB
            // 
            logTB.Location = new Point(46, 299);
            logTB.Name = "logTB";
            logTB.ReadOnly = true;
            logTB.Size = new Size(712, 120);
            logTB.TabIndex = 7;
            logTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logTB);
            Controls.Add(label3);
            Controls.Add(raioTB);
            Controls.Add(label2);
            Controls.Add(larguraTB);
            Controls.Add(label1);
            Controls.Add(alturaTB);
            Controls.Add(calcBut);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcBut;
        private RichTextBox alturaTB;
        private Label label1;
        private Label label2;
        private RichTextBox larguraTB;
        private RichTextBox raioTB;
        private Label label3;
        private RichTextBox logTB;
    }
}
