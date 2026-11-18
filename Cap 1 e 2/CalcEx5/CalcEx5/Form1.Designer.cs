namespace CalcEx5
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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            equals = new Button();
            add = new Button();
            subtract = new Button();
            multiply = new Button();
            divide = new Button();
            clear = new Button();
            Result = new RichTextBox();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(36, 213);
            button7.Name = "button7";
            button7.Size = new Size(71, 56);
            button7.TabIndex = 0;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(139, 213);
            button8.Name = "button8";
            button8.Size = new Size(71, 56);
            button8.TabIndex = 1;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(244, 213);
            button9.Name = "button9";
            button9.Size = new Size(71, 56);
            button9.TabIndex = 2;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.Location = new Point(36, 275);
            button4.Name = "button4";
            button4.Size = new Size(71, 56);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(139, 275);
            button5.Name = "button5";
            button5.Size = new Size(71, 56);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(244, 275);
            button6.Name = "button6";
            button6.Size = new Size(71, 56);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(36, 337);
            button1.Name = "button1";
            button1.Size = new Size(71, 56);
            button1.TabIndex = 6;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(139, 337);
            button2.Name = "button2";
            button2.Size = new Size(71, 56);
            button2.TabIndex = 7;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(244, 337);
            button3.Name = "button3";
            button3.Size = new Size(71, 56);
            button3.TabIndex = 8;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // equals
            // 
            equals.Location = new Point(359, 399);
            equals.Name = "equals";
            equals.Size = new Size(71, 56);
            equals.TabIndex = 9;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // add
            // 
            add.Location = new Point(359, 337);
            add.Name = "add";
            add.Size = new Size(71, 56);
            add.TabIndex = 10;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // subtract
            // 
            subtract.Location = new Point(359, 275);
            subtract.Name = "subtract";
            subtract.Size = new Size(71, 56);
            subtract.TabIndex = 11;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += subtract_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(359, 213);
            multiply.Name = "multiply";
            multiply.Size = new Size(71, 56);
            multiply.TabIndex = 12;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.Location = new Point(359, 151);
            divide.Name = "divide";
            divide.Size = new Size(71, 56);
            divide.TabIndex = 13;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // clear
            // 
            clear.Location = new Point(244, 151);
            clear.Name = "clear";
            clear.Size = new Size(71, 56);
            clear.TabIndex = 14;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Result
            // 
            Result.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Result.Font = new Font("Segoe UI", 16F);
            Result.Location = new Point(36, 33);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.RightToLeft = RightToLeft.Yes;
            Result.Size = new Size(394, 81);
            Result.TabIndex = 15;
            Result.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 485);
            Controls.Add(Result);
            Controls.Add(clear);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(subtract);
            Controls.Add(add);
            Controls.Add(equals);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button equals;
        private Button add;
        private Button subtract;
        private Button multiply;
        private Button divide;
        private Button clear;
        private RichTextBox Result;
    }
}
