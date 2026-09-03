namespace CSE1322L___Lab_12
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Answer = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 35);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 35);
            textBox2.TabIndex = 1;
            // 
            // Answer
            // 
            Answer.AutoSize = true;
            Answer.Location = new Point(41, 139);
            Answer.Name = "Answer";
            Answer.Size = new Size(0, 30);
            Answer.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(161, 71);
            button1.Name = "button1";
            button1.Size = new Size(46, 40);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(147, 173);
            button2.Name = "button2";
            button2.Size = new Size(74, 40);
            button2.TabIndex = 4;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 236);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Answer);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "MegaCalc!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label Answer;
        private Button button1;
        private Button button2;
    }
}
