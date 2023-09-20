namespace calculator
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
            openFileDialog1 = new OpenFileDialog();
            button_7 = new Button();
            button_4 = new Button();
            button_1 = new Button();
            button_0 = new Button();
            button_8 = new Button();
            button_2 = new Button();
            button_5 = new Button();
            button_9 = new Button();
            button_6 = new Button();
            button_divided = new Button();
            button_3 = new Button();
            button_decimal = new Button();
            button_times = new Button();
            button_min = new Button();
            button_plus = new Button();
            button_del = new Button();
            button_eq = new Button();
            button17 = new Button();
            current_op = new Label();
            display_res = new TextBox();
            button19 = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_7
            // 
            button_7.BackColor = SystemColors.ButtonShadow;
            button_7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_7.ForeColor = SystemColors.ButtonHighlight;
            button_7.Location = new Point(12, 89);
            button_7.Name = "button_7";
            button_7.Size = new Size(60, 60);
            button_7.TabIndex = 1;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = false;
            button_7.Click += button_click;
            // 
            // button_4
            // 
            button_4.BackColor = SystemColors.ButtonShadow;
            button_4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_4.ForeColor = SystemColors.ButtonHighlight;
            button_4.Location = new Point(12, 150);
            button_4.Name = "button_4";
            button_4.Size = new Size(60, 60);
            button_4.TabIndex = 2;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = false;
            button_4.Click += button_click;
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.ButtonShadow;
            button_1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_1.ForeColor = SystemColors.ButtonHighlight;
            button_1.Location = new Point(12, 211);
            button_1.Name = "button_1";
            button_1.Size = new Size(60, 60);
            button_1.TabIndex = 3;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_click;
            // 
            // button_0
            // 
            button_0.BackColor = SystemColors.ButtonShadow;
            button_0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_0.ForeColor = SystemColors.ButtonHighlight;
            button_0.Location = new Point(12, 272);
            button_0.Name = "button_0";
            button_0.Size = new Size(122, 60);
            button_0.TabIndex = 4;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = false;
            button_0.Click += button_click;
            // 
            // button_8
            // 
            button_8.BackColor = SystemColors.ButtonShadow;
            button_8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_8.ForeColor = SystemColors.ButtonHighlight;
            button_8.Location = new Point(74, 89);
            button_8.Name = "button_8";
            button_8.Size = new Size(60, 60);
            button_8.TabIndex = 5;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = false;
            button_8.Click += button_click;
            // 
            // button_2
            // 
            button_2.BackColor = SystemColors.ButtonShadow;
            button_2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_2.ForeColor = SystemColors.ButtonHighlight;
            button_2.Location = new Point(74, 211);
            button_2.Name = "button_2";
            button_2.Size = new Size(60, 60);
            button_2.TabIndex = 6;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = false;
            button_2.Click += button_click;
            // 
            // button_5
            // 
            button_5.BackColor = SystemColors.ButtonShadow;
            button_5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_5.ForeColor = SystemColors.ButtonHighlight;
            button_5.Location = new Point(74, 150);
            button_5.Name = "button_5";
            button_5.Size = new Size(60, 60);
            button_5.TabIndex = 7;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = false;
            button_5.Click += button_click;
            // 
            // button_9
            // 
            button_9.BackColor = SystemColors.ButtonShadow;
            button_9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_9.ForeColor = SystemColors.ButtonHighlight;
            button_9.Location = new Point(136, 89);
            button_9.Name = "button_9";
            button_9.Size = new Size(60, 60);
            button_9.TabIndex = 8;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = false;
            button_9.Click += button_click;
            // 
            // button_6
            // 
            button_6.BackColor = SystemColors.ButtonShadow;
            button_6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_6.ForeColor = SystemColors.ButtonHighlight;
            button_6.Location = new Point(136, 150);
            button_6.Name = "button_6";
            button_6.Size = new Size(60, 60);
            button_6.TabIndex = 9;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = false;
            button_6.Click += button_click;
            // 
            // button_divided
            // 
            button_divided.BackColor = SystemColors.ButtonShadow;
            button_divided.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_divided.ForeColor = SystemColors.ButtonHighlight;
            button_divided.Location = new Point(214, 89);
            button_divided.Margin = new Padding(3, 0, 3, 0);
            button_divided.Name = "button_divided";
            button_divided.Size = new Size(60, 60);
            button_divided.TabIndex = 10;
            button_divided.Text = "÷";
            button_divided.UseVisualStyleBackColor = false;
            button_divided.Click += operation_click;
            // 
            // button_3
            // 
            button_3.BackColor = SystemColors.ButtonShadow;
            button_3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_3.ForeColor = SystemColors.ButtonHighlight;
            button_3.Location = new Point(136, 211);
            button_3.Name = "button_3";
            button_3.Size = new Size(60, 60);
            button_3.TabIndex = 12;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = false;
            button_3.Click += button_click;
            // 
            // button_decimal
            // 
            button_decimal.BackColor = SystemColors.ButtonShadow;
            button_decimal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_decimal.ForeColor = SystemColors.ButtonHighlight;
            button_decimal.Location = new Point(136, 272);
            button_decimal.Name = "button_decimal";
            button_decimal.Size = new Size(60, 60);
            button_decimal.TabIndex = 13;
            button_decimal.Text = ".";
            button_decimal.UseVisualStyleBackColor = false;
            button_decimal.Click += button_click;
            // 
            // button_times
            // 
            button_times.BackColor = SystemColors.ButtonShadow;
            button_times.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_times.ForeColor = SystemColors.ButtonHighlight;
            button_times.Location = new Point(214, 150);
            button_times.Margin = new Padding(3, 0, 3, 0);
            button_times.Name = "button_times";
            button_times.Size = new Size(60, 60);
            button_times.TabIndex = 14;
            button_times.Text = "x";
            button_times.UseVisualStyleBackColor = false;
            button_times.Click += operation_click;
            // 
            // button_min
            // 
            button_min.BackColor = SystemColors.ButtonShadow;
            button_min.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_min.ForeColor = SystemColors.ButtonHighlight;
            button_min.Location = new Point(214, 211);
            button_min.Margin = new Padding(3, 0, 3, 0);
            button_min.Name = "button_min";
            button_min.Size = new Size(60, 60);
            button_min.TabIndex = 15;
            button_min.Text = "-";
            button_min.UseVisualStyleBackColor = false;
            button_min.Click += operation_click;
            // 
            // button_plus
            // 
            button_plus.BackColor = SystemColors.ButtonShadow;
            button_plus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_plus.ForeColor = SystemColors.ButtonHighlight;
            button_plus.Location = new Point(214, 272);
            button_plus.Margin = new Padding(3, 0, 3, 0);
            button_plus.Name = "button_plus";
            button_plus.Size = new Size(60, 60);
            button_plus.TabIndex = 16;
            button_plus.Text = "+";
            button_plus.UseVisualStyleBackColor = false;
            button_plus.Click += operation_click;
            // 
            // button_del
            // 
            button_del.BackColor = SystemColors.ButtonShadow;
            button_del.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_del.ForeColor = SystemColors.ButtonHighlight;
            button_del.Location = new Point(276, 89);
            button_del.Name = "button_del";
            button_del.Size = new Size(60, 60);
            button_del.TabIndex = 17;
            button_del.Text = "DEL";
            button_del.UseVisualStyleBackColor = false;
            button_del.Click += button_del_Click;
            // 
            // button_eq
            // 
            button_eq.BackColor = SystemColors.ButtonShadow;
            button_eq.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_eq.ForeColor = SystemColors.ButtonHighlight;
            button_eq.Location = new Point(276, 272);
            button_eq.Name = "button_eq";
            button_eq.Size = new Size(60, 60);
            button_eq.TabIndex = 18;
            button_eq.Text = "=";
            button_eq.UseVisualStyleBackColor = false;
            button_eq.Click += button_eq_Click;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.ButtonShadow;
            button17.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = SystemColors.ButtonHighlight;
            button17.Location = new Point(276, 150);
            button17.Name = "button17";
            button17.Size = new Size(60, 60);
            button17.TabIndex = 20;
            button17.Text = "CE";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // current_op
            // 
            current_op.AutoSize = true;
            current_op.Location = new Point(12, 3);
            current_op.Name = "current_op";
            current_op.Size = new Size(0, 15);
            current_op.TabIndex = 21;
            // 
            // display_res
            // 
            display_res.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            display_res.Location = new Point(12, 21);
            display_res.Margin = new Padding(3, 0, 3, 0);
            display_res.Multiline = true;
            display_res.Name = "display_res";
            display_res.Size = new Size(324, 62);
            display_res.TabIndex = 22;
            display_res.Text = "0";
            display_res.TextAlign = HorizontalAlignment.Right;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.ButtonShadow;
            button19.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button19.ForeColor = SystemColors.ButtonHighlight;
            button19.Location = new Point(276, 211);
            button19.Name = "button19";
            button19.Size = new Size(60, 60);
            button19.TabIndex = 23;
            button19.Text = "C";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(349, 350);
            Controls.Add(button19);
            Controls.Add(display_res);
            Controls.Add(current_op);
            Controls.Add(button17);
            Controls.Add(button_eq);
            Controls.Add(button_del);
            Controls.Add(button_plus);
            Controls.Add(button_min);
            Controls.Add(button_times);
            Controls.Add(button_decimal);
            Controls.Add(button_3);
            Controls.Add(button_divided);
            Controls.Add(button_6);
            Controls.Add(button_9);
            Controls.Add(button_5);
            Controls.Add(button_2);
            Controls.Add(button_8);
            Controls.Add(button_0);
            Controls.Add(button_1);
            Controls.Add(button_4);
            Controls.Add(button_7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button_7;
        private Button button_4;
        private Button button_1;
        private Button button_0;
        private Button button_8;
        private Button button_2;
        private Button button_5;
        private Button button_9;
        private Button button_6;
        private Button button_divided;
        private Button button_3;
        private Button button_decimal;
        private Button button_times;
        private Button button_min;
        private Button button_plus;
        private Button button_del;
        private Button button_eq;
        private Button button17;
        private Label current_op;
        private TextBox display_res;
        private Button button19;
    }
}