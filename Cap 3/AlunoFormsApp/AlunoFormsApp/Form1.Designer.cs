namespace AlunoFormsApp
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
            label3 = new Label();
            cursoTB = new RichTextBox();
            label4 = new Label();
            idadeTB = new RichTextBox();
            label5 = new Label();
            anoTB = new RichTextBox();
            criarAlunoBut = new Button();
            logTB = new RichTextBox();
            label6 = new Label();
            nomeDirTB = new RichTextBox();
            dirBut = new Button();
            mostrarDirBut = new Button();
            SuspendLayout();
            // 
            // nomeTB
            // 
            nomeTB.Location = new Point(108, 64);
            nomeTB.Multiline = false;
            nomeTB.Name = "nomeTB";
            nomeTB.Size = new Size(125, 42);
            nomeTB.TabIndex = 0;
            nomeTB.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 32);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 2;
            label2.Text = "Informação do Aluno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 146);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Curso";
            // 
            // cursoTB
            // 
            cursoTB.Location = new Point(108, 134);
            cursoTB.Multiline = false;
            cursoTB.Name = "cursoTB";
            cursoTB.Size = new Size(125, 42);
            cursoTB.TabIndex = 3;
            cursoTB.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 76);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 6;
            label4.Text = "Idade";
            // 
            // idadeTB
            // 
            idadeTB.Location = new Point(385, 64);
            idadeTB.Multiline = false;
            idadeTB.Name = "idadeTB";
            idadeTB.Size = new Size(125, 42);
            idadeTB.TabIndex = 5;
            idadeTB.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(315, 146);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 8;
            label5.Text = "Ano";
            // 
            // anoTB
            // 
            anoTB.Location = new Point(385, 134);
            anoTB.Multiline = false;
            anoTB.Name = "anoTB";
            anoTB.Size = new Size(125, 42);
            anoTB.TabIndex = 7;
            anoTB.Text = "";
            // 
            // criarAlunoBut
            // 
            criarAlunoBut.Location = new Point(630, 87);
            criarAlunoBut.Name = "criarAlunoBut";
            criarAlunoBut.Size = new Size(125, 67);
            criarAlunoBut.TabIndex = 9;
            criarAlunoBut.Text = "Criar Aluno";
            criarAlunoBut.UseVisualStyleBackColor = true;
            criarAlunoBut.Click += criarAlunoBut_Click;
            // 
            // logTB
            // 
            logTB.Location = new Point(42, 236);
            logTB.Name = "logTB";
            logTB.ReadOnly = true;
            logTB.Size = new Size(713, 143);
            logTB.TabIndex = 10;
            logTB.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 445);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 12;
            label6.Text = "Novo Diretor de TIC";
            // 
            // nomeDirTB
            // 
            nomeDirTB.Location = new Point(195, 437);
            nomeDirTB.Multiline = false;
            nomeDirTB.Name = "nomeDirTB";
            nomeDirTB.Size = new Size(167, 42);
            nomeDirTB.TabIndex = 11;
            nomeDirTB.Text = "";
            // 
            // dirBut
            // 
            dirBut.Location = new Point(385, 422);
            dirBut.Name = "dirBut";
            dirBut.Size = new Size(113, 67);
            dirBut.TabIndex = 13;
            dirBut.Text = "Mudar nome do Diretor";
            dirBut.UseVisualStyleBackColor = true;
            dirBut.Click += dirBut_Click;
            // 
            // mostrarDirBut
            // 
            mostrarDirBut.Location = new Point(661, 423);
            mostrarDirBut.Name = "mostrarDirBut";
            mostrarDirBut.Size = new Size(94, 64);
            mostrarDirBut.TabIndex = 14;
            mostrarDirBut.Text = "Mostrar Diretor";
            mostrarDirBut.UseVisualStyleBackColor = true;
            mostrarDirBut.Click += mostrarDirBut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(mostrarDirBut);
            Controls.Add(dirBut);
            Controls.Add(label6);
            Controls.Add(nomeDirTB);
            Controls.Add(logTB);
            Controls.Add(criarAlunoBut);
            Controls.Add(label5);
            Controls.Add(anoTB);
            Controls.Add(label4);
            Controls.Add(idadeTB);
            Controls.Add(label3);
            Controls.Add(cursoTB);
            Controls.Add(label2);
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
        private Label label3;
        private RichTextBox cursoTB;
        private Label label4;
        private RichTextBox idadeTB;
        private Label label5;
        private RichTextBox anoTB;
        private Button criarAlunoBut;
        private RichTextBox logTB;
        private Label label6;
        private RichTextBox nomeDirTB;
        private Button dirBut;
        private Button mostrarDirBut;
    }
}
