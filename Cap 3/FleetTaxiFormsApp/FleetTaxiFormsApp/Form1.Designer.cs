namespace FleetTaxiFormsApp
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
            groupBox1 = new GroupBox();
            addBut = new Button();
            label1 = new Label();
            label2 = new Label();
            matriculaTB = new RichTextBox();
            modeloTB = new RichTextBox();
            logTB = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(modeloTB);
            groupBox1.Controls.Add(matriculaTB);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(addBut);
            groupBox1.Location = new Point(51, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 210);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar Taxi";
            // 
            // addBut
            // 
            addBut.Location = new Point(170, 153);
            addBut.Name = "addBut";
            addBut.Size = new Size(120, 39);
            addBut.TabIndex = 0;
            addBut.Text = "Adicionar";
            addBut.UseVisualStyleBackColor = true;
            addBut.Click += addBut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Matrícula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 101);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 2;
            label2.Text = "Modelo";
            // 
            // matriculaTB
            // 
            matriculaTB.Location = new Point(155, 26);
            matriculaTB.Multiline = false;
            matriculaTB.Name = "matriculaTB";
            matriculaTB.Size = new Size(231, 39);
            matriculaTB.TabIndex = 3;
            matriculaTB.Text = "";
            // 
            // modeloTB
            // 
            modeloTB.Location = new Point(155, 90);
            modeloTB.Multiline = false;
            modeloTB.Name = "modeloTB";
            modeloTB.Size = new Size(231, 39);
            modeloTB.TabIndex = 4;
            modeloTB.Text = "";
            // 
            // logTB
            // 
            logTB.Location = new Point(51, 303);
            logTB.Name = "logTB";
            logTB.ReadOnly = true;
            logTB.Size = new Size(694, 120);
            logTB.TabIndex = 1;
            logTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logTB);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox modeloTB;
        private RichTextBox matriculaTB;
        private Label label2;
        private Label label1;
        private Button addBut;
        private RichTextBox logTB;
    }
}
