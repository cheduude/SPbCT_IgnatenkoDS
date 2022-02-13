namespace WinForms_Calc_50311
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
            this.textBox_first = new System.Windows.Forms.TextBox();
            this.textBox_second = new System.Windows.Forms.TextBox();
            this.button_zvd = new System.Windows.Forms.Button();
            this.button_and = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_zum = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_first
            // 
            this.textBox_first.Location = new System.Drawing.Point(179, 132);
            this.textBox_first.Name = "textBox_first";
            this.textBox_first.Size = new System.Drawing.Size(100, 23);
            this.textBox_first.TabIndex = 0;
            // 
            // textBox_second
            // 
            this.textBox_second.Location = new System.Drawing.Point(179, 203);
            this.textBox_second.Name = "textBox_second";
            this.textBox_second.Size = new System.Drawing.Size(100, 23);
            this.textBox_second.TabIndex = 1;
            // 
            // button_zvd
            // 
            this.button_zvd.Location = new System.Drawing.Point(407, 132);
            this.button_zvd.Name = "button_zvd";
            this.button_zvd.Size = new System.Drawing.Size(75, 23);
            this.button_zvd.TabIndex = 2;
            this.button_zvd.Text = "x*y";
            this.button_zvd.UseVisualStyleBackColor = true;
            // 
            // button_and
            // 
            this.button_and.Location = new System.Drawing.Point(574, 132);
            this.button_and.Name = "button_and";
            this.button_and.Size = new System.Drawing.Size(75, 23);
            this.button_and.TabIndex = 3;
            this.button_and.Text = "x & y";
            this.button_and.UseVisualStyleBackColor = true;
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(407, 203);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(75, 23);
            this.button_div.TabIndex = 4;
            this.button_div.Text = "x>>=y";
            this.button_div.UseVisualStyleBackColor = true;
            // 
            // button_zum
            // 
            this.button_zum.Location = new System.Drawing.Point(574, 203);
            this.button_zum.Name = "button_zum";
            this.button_zum.Size = new System.Drawing.Size(75, 23);
            this.button_zum.TabIndex = 5;
            this.button_zum.Text = "x*=x";
            this.button_zum.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(179, 300);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 15);
            this.label.TabIndex = 6;
            this.label.Text = "Результат";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(179, 343);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(0, 15);
            this.label_text.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_zum);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_and);
            this.Controls.Add(this.button_zvd);
            this.Controls.Add(this.textBox_second);
            this.Controls.Add(this.textBox_first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_first;
        private System.Windows.Forms.TextBox textBox_second;
        private System.Windows.Forms.Button button_zvd;
        private System.Windows.Forms.Button button_and;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_zum;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label_text;
    }
}

