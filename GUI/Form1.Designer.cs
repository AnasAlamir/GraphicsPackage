namespace GUI
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
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            textBox3 = new TextBox();
            groupBox4 = new GroupBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 533);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "DDA Line";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Location = new Point(184, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 604);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 5;
            label1.Text = "x0";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(32, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 389);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(72, 54);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(90, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(72, 54);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 5;
            label2.Text = "y0";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 19);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(32, 23);
            textBox2.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(12, 461);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(72, 54);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 5;
            label3.Text = "x1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(31, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(32, 23);
            textBox3.TabIndex = 6;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Location = new Point(90, 461);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(72, 54);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Location = new Point(6, 22);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 5;
            label4.Text = "y1";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(31, 19);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(32, 23);
            textBox4.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(12, 582);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Bresenham Line";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1108, 652);
            Controls.Add(button2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox textBox3;
        private GroupBox groupBox4;
        private Label label4;
        private TextBox textBox4;
        private Button button2;
    }
}
