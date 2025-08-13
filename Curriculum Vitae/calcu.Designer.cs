namespace Calculator
{
    partial class calcu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Equals = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display.Location = new System.Drawing.Point(12, 28);
            this.display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(0, 25);
            this.display.TabIndex = 0;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 62);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Equals
            // 
            this.Equals.Location = new System.Drawing.Point(340, 456);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(91, 133);
            this.Equals.TabIndex = 4;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 84);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 84);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 84);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(232, 305);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 84);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 84);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(123, 505);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(102, 84);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(13, 505);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(102, 84);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(341, 393);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(90, 57);
            this.Divide.TabIndex = 17;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(341, 330);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(90, 57);
            this.Multiply.TabIndex = 18;
            this.Multiply.Text = "*";
            this.Multiply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(341, 206);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(90, 57);
            this.Add.TabIndex = 20;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(341, 268);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(90, 57);
            this.Subtract.TabIndex = 19;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(232, 206);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 84);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(123, 206);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 84);
            this.button8.TabIndex = 22;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // Decimal
            // 
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal.Location = new System.Drawing.Point(232, 505);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(102, 84);
            this.Decimal.TabIndex = 23;
            this.Decimal.Text = ".";
            this.Decimal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // calcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(447, 607);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "calcu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Decimal;
    }
}

