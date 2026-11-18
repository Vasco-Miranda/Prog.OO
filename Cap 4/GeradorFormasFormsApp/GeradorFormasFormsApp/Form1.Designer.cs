namespace GeradorFormasFormsApp
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
            outTb = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // outTb
            // 
            outTb.Location = new Point(58, 187);
            outTb.Name = "outTb";
            outTb.ReadOnly = true;
            outTb.Size = new Size(675, 228);
            outTb.TabIndex = 0;
            outTb.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(326, 64);
            button1.Name = "button1";
            button1.Size = new Size(148, 71);
            button1.TabIndex = 1;
            button1.Text = "Testar - Criar Formas Aleatórias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(outTb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox outTb;
        private Button button1;
    }
}
