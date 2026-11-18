namespace BancoFormsApp
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
            createBut = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            saldoTB = new RichTextBox();
            nameTB = new RichTextBox();
            logTB = new RichTextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            subBut = new Button();
            addBut = new Button();
            label4 = new Label();
            valueTB = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // createBut
            // 
            createBut.Location = new Point(345, 68);
            createBut.Name = "createBut";
            createBut.Size = new Size(116, 61);
            createBut.TabIndex = 0;
            createBut.Text = "Criar Cliente";
            createBut.UseVisualStyleBackColor = true;
            createBut.Click += createBut_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(createBut);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(saldoTB);
            groupBox1.Controls.Add(nameTB);
            groupBox1.Location = new Point(36, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 178);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criar Conta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 109);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Saldo Inicial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome do Titular";
            // 
            // saldoTB
            // 
            saldoTB.Location = new Point(169, 106);
            saldoTB.Multiline = false;
            saldoTB.Name = "saldoTB";
            saldoTB.Size = new Size(129, 44);
            saldoTB.TabIndex = 4;
            saldoTB.Text = "";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(169, 37);
            nameTB.Multiline = false;
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(129, 44);
            nameTB.TabIndex = 2;
            nameTB.Text = "";
            // 
            // logTB
            // 
            logTB.Location = new Point(36, 290);
            logTB.Name = "logTB";
            logTB.ReadOnly = true;
            logTB.Size = new Size(804, 120);
            logTB.TabIndex = 2;
            logTB.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 265);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 3;
            label3.Text = "Logs";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(subBut);
            groupBox2.Controls.Add(addBut);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(valueTB);
            groupBox2.Location = new Point(595, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 178);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alterar Saldo";
            // 
            // subBut
            // 
            subBut.Location = new Point(140, 121);
            subBut.Name = "subBut";
            subBut.Size = new Size(94, 29);
            subBut.TabIndex = 8;
            subBut.Text = "Retirar";
            subBut.UseVisualStyleBackColor = true;
            subBut.Click += subBut_Click;
            // 
            // addBut
            // 
            addBut.Location = new Point(19, 121);
            addBut.Name = "addBut";
            addBut.Size = new Size(94, 29);
            addBut.TabIndex = 7;
            addBut.Text = "Adicionar";
            addBut.UseVisualStyleBackColor = true;
            addBut.Click += addBut_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 51);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 6;
            label4.Text = "Valor";
            // 
            // valueTB
            // 
            valueTB.Location = new Point(92, 37);
            valueTB.Name = "valueTB";
            valueTB.Size = new Size(142, 44);
            valueTB.TabIndex = 0;
            valueTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 450);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(logTB);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createBut;
        private GroupBox groupBox1;
        private Label label1;
        private RichTextBox nameTB;
        private Label label2;
        private RichTextBox saldoTB;
        private RichTextBox logTB;
        private Label label3;
        private GroupBox groupBox2;
        private Button subBut;
        private Button addBut;
        private Label label4;
        private RichTextBox valueTB;
    }
}
