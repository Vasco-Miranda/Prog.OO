namespace LibraryManagerFormsApp
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
            pagsTB = new RichTextBox();
            autorTB = new RichTextBox();
            tituloTB = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            criarLivroBut = new Button();
            logTB = new RichTextBox();
            groupBox2 = new GroupBox();
            searchTitleTB = new RichTextBox();
            label4 = new Label();
            searchBut = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pagsTB);
            groupBox1.Controls.Add(autorTB);
            groupBox1.Controls.Add(tituloTB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(criarLivroBut);
            groupBox1.Location = new Point(27, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar Livro";
            // 
            // pagsTB
            // 
            pagsTB.Location = new Point(173, 170);
            pagsTB.Multiline = false;
            pagsTB.Name = "pagsTB";
            pagsTB.Size = new Size(125, 37);
            pagsTB.TabIndex = 6;
            pagsTB.Text = "";
            // 
            // autorTB
            // 
            autorTB.Location = new Point(173, 111);
            autorTB.Multiline = false;
            autorTB.Name = "autorTB";
            autorTB.Size = new Size(125, 37);
            autorTB.TabIndex = 5;
            autorTB.Text = "";
            // 
            // tituloTB
            // 
            tituloTB.Location = new Point(173, 47);
            tituloTB.Multiline = false;
            tituloTB.Name = "tituloTB";
            tituloTB.Size = new Size(125, 37);
            tituloTB.TabIndex = 4;
            tituloTB.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 170);
            label3.Name = "label3";
            label3.Size = new Size(84, 40);
            label3.TabIndex = 3;
            label3.Text = "Número de\r\npáginas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 118);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "Título";
            // 
            // criarLivroBut
            // 
            criarLivroBut.Location = new Point(111, 235);
            criarLivroBut.Name = "criarLivroBut";
            criarLivroBut.Size = new Size(94, 29);
            criarLivroBut.TabIndex = 0;
            criarLivroBut.Text = "Adicionar";
            criarLivroBut.UseVisualStyleBackColor = true;
            criarLivroBut.Click += criarLivroBut_Click;
            // 
            // logTB
            // 
            logTB.Location = new Point(27, 362);
            logTB.Name = "logTB";
            logTB.ReadOnly = true;
            logTB.Size = new Size(743, 120);
            logTB.TabIndex = 1;
            logTB.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(searchBut);
            groupBox2.Controls.Add(searchTitleTB);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(435, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 202);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Processar Empréstimo";
            // 
            // searchTitleTB
            // 
            searchTitleTB.Location = new Point(167, 46);
            searchTitleTB.Multiline = false;
            searchTitleTB.Name = "searchTitleTB";
            searchTitleTB.Size = new Size(125, 37);
            searchTitleTB.TabIndex = 8;
            searchTitleTB.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 54);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 7;
            label4.Text = "Título";
            // 
            // searchBut
            // 
            searchBut.Location = new Point(117, 134);
            searchBut.Name = "searchBut";
            searchBut.Size = new Size(94, 29);
            searchBut.TabIndex = 7;
            searchBut.Text = "Requisitar";
            searchBut.UseVisualStyleBackColor = true;
            searchBut.Click += searchBut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(groupBox2);
            Controls.Add(logTB);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox pagsTB;
        private RichTextBox autorTB;
        private RichTextBox tituloTB;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button criarLivroBut;
        private RichTextBox logTB;
        private GroupBox groupBox2;
        private RichTextBox searchTitleTB;
        private Label label4;
        private Button searchBut;
    }
}
