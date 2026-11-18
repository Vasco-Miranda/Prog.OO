namespace WinFormsApp1
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
            richTextBox = new RichTextBox();
            limpar = new Button();
            executar = new Button();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(99, 110);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(202, 89);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // limpar
            // 
            limpar.Location = new Point(388, 143);
            limpar.Name = "limpar";
            limpar.Size = new Size(94, 29);
            limpar.TabIndex = 1;
            limpar.Text = "Limpar";
            limpar.UseVisualStyleBackColor = true;
            limpar.Click += limpar_Click;
            // 
            // executar
            // 
            executar.Location = new Point(529, 143);
            executar.Name = "executar";
            executar.Size = new Size(94, 29);
            executar.TabIndex = 2;
            executar.Text = "Executar";
            executar.UseVisualStyleBackColor = true;
            executar.Click += executar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(executar);
            Controls.Add(limpar);
            Controls.Add(richTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
        private Button limpar;
        private Button executar;
    }
}
