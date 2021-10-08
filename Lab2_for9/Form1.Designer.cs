namespace Lab2_for9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_subsequeence = new System.Windows.Forms.TextBox();
            this.button_solution = new System.Windows.Forms.Button();
            this.label_MInAnswer = new System.Windows.Forms.Label();
            this.label_Max_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(600, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дана последовательность различных чисел. Найти два наибольших и два наименьших ее" +
    " элемента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Последовательность чисел";
            // 
            // textBox1_subsequeence
            // 
            this.textBox1_subsequeence.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1_subsequeence.Location = new System.Drawing.Point(236, 63);
            this.textBox1_subsequeence.Name = "textBox1_subsequeence";
            this.textBox1_subsequeence.Size = new System.Drawing.Size(336, 33);
            this.textBox1_subsequeence.TabIndex = 2;
            // 
            // button_solution
            // 
            this.button_solution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_solution.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_solution.Location = new System.Drawing.Point(225, 197);
            this.button_solution.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.button_solution.Name = "button_solution";
            this.button_solution.Size = new System.Drawing.Size(150, 50);
            this.button_solution.TabIndex = 3;
            this.button_solution.Text = "Найти";
            this.button_solution.UseVisualStyleBackColor = true;
            // 
            // label_MInAnswer
            // 
            this.label_MInAnswer.AutoSize = true;
            this.label_MInAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_MInAnswer.Location = new System.Drawing.Point(30, 120);
            this.label_MInAnswer.Name = "label_MInAnswer";
            this.label_MInAnswer.Size = new System.Drawing.Size(52, 21);
            this.label_MInAnswer.TabIndex = 4;
            this.label_MInAnswer.Text = "label3";
            // 
            // label_Max_Answer
            // 
            this.label_Max_Answer.AutoSize = true;
            this.label_Max_Answer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Max_Answer.Location = new System.Drawing.Point(30, 160);
            this.label_Max_Answer.Name = "label_Max_Answer";
            this.label_Max_Answer.Size = new System.Drawing.Size(52, 21);
            this.label_Max_Answer.TabIndex = 5;
            this.label_Max_Answer.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label_Max_Answer);
            this.Controls.Add(this.label_MInAnswer);
            this.Controls.Add(this.button_solution);
            this.Controls.Add(this.textBox1_subsequeence);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Задача на for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_subsequeence;
        private System.Windows.Forms.Button button_solution;
        private System.Windows.Forms.Label label_MInAnswer;
        private System.Windows.Forms.Label label_Max_Answer;
    }
}

