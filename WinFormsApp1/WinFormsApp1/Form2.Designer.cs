﻿namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(133, 37);
            label1.TabIndex = 0;
            label1.Text = "類別編號";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(75, 37);
            label2.TabIndex = 1;
            label2.Text = "品名";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(75, 37);
            label3.TabIndex = 2;
            label3.Text = "單價";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(75, 37);
            label4.TabIndex = 3;
            label4.Text = "說明";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 38);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(301, 9);
            button1.Name = "button1";
            button1.Size = new Size(122, 59);
            button1.TabIndex = 8;
            button1.Text = "新增";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(301, 82);
            button2.Name = "button2";
            button2.Size = new Size(122, 59);
            button2.TabIndex = 9;
            button2.Text = "修改";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(301, 152);
            button3.Name = "button3";
            button3.Size = new Size(122, 59);
            button3.TabIndex = 10;
            button3.Text = "刪除";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(411, 205);
            dataGridView1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(151, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 38);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(151, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 38);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(151, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 38);
            textBox3.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 447);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}