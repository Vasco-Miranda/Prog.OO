namespace Cap3_Ex4_MinMax
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
            rtb1 = new RichTextBox();
            rtb2 = new RichTextBox();
            label2 = new Label();
            resultRTB = new RichTextBox();
            label3 = new Label();
            butCalc = new Button();
            max = new RadioButton();
            groupBox1 = new GroupBox();
            min = new RadioButton();
            rtb3 = new RichTextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 50);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor 1*";
            // 
            // rtb1
            // 
            rtb1.Location = new Point(59, 73);
            rtb1.Name = "rtb1";
            rtb1.Size = new Size(125, 35);
            rtb1.TabIndex = 1;
            rtb1.Text = "";
            // 
            // rtb2
            // 
            rtb2.Location = new Point(59, 147);
            rtb2.Name = "rtb2";
            rtb2.Size = new Size(125, 35);
            rtb2.TabIndex = 3;
            rtb2.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 124);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Valor 2*";
            // 
            // resultRTB
            // 
            resultRTB.Enabled = false;
            resultRTB.Location = new Point(59, 307);
            resultRTB.Name = "resultRTB";
            resultRTB.Size = new Size(125, 35);
            resultRTB.TabIndex = 5;
            resultRTB.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 284);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Resultado";
            // 
            // butCalc
            // 
            butCalc.Enabled = false;
            butCalc.Location = new Point(315, 246);
            butCalc.Name = "butCalc";
            butCalc.Size = new Size(94, 29);
            butCalc.TabIndex = 6;
            butCalc.Text = "Calcular";
            butCalc.UseVisualStyleBackColor = true;
            butCalc.Click += butCalc_Click;
            // 
            // max
            // 
            max.AutoSize = true;
            max.Location = new Point(27, 39);
            max.Name = "max";
            max.Size = new Size(84, 24);
            max.TabIndex = 7;
            max.TabStop = true;
            max.Text = "Máximo";
            max.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(min);
            groupBox1.Controls.Add(max);
            groupBox1.Location = new Point(268, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Min/Max";
            // 
            // min
            // 
            min.AutoSize = true;
            min.Location = new Point(27, 80);
            min.Name = "min";
            min.Size = new Size(81, 24);
            min.TabIndex = 8;
            min.TabStop = true;
            min.Text = "Mínimo";
            min.UseVisualStyleBackColor = true;
            // 
            // rtb3
            // 
            rtb3.Location = new Point(59, 231);
            rtb3.Name = "rtb3";
            rtb3.Size = new Size(125, 35);
            rtb3.TabIndex = 10;
            rtb3.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 208);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Valor 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 440);
            Controls.Add(rtb3);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(butCalc);
            Controls.Add(resultRTB);
            Controls.Add(label3);
            Controls.Add(rtb2);
            Controls.Add(label2);
            Controls.Add(rtb1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtb1;
        private RichTextBox rtb2;
        private Label label2;
        private RichTextBox resultRTB;
        private Label label3;
        private Button butCalc;
        private RadioButton max;
        private GroupBox groupBox1;
        private RadioButton min;
        private RichTextBox rtb3;
        private Label label4;
    }
}
