﻿namespace THPTTKHT_QLRapChieuPhim
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 25.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 30);
            label1.Name = "label1";
            label1.Size = new Size(661, 50);
            label1.TabIndex = 0;
            label1.Text = "Ứng dụng quản lý rạp chiếu phim";
            label1.TextAlign = ContentAlignment.TopCenter;

            // 
            // button1 - Quản lý phim
            // 
            button1.Location = new Point(150, 120);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 1;
            button1.Text = "🎥 Quản lý phim";
            button1.UseVisualStyleBackColor = true;

            // 
            // button2 - Lịch chiếu
            // 
            button2.Location = new Point(330, 120);
            button2.Name = "button2";
            button2.Size = new Size(160, 50);
            button2.TabIndex = 2;
            button2.Text = "🕒 Lịch chiếu";
            button2.UseVisualStyleBackColor = true;

            // 
            // button3 - Giá vé
            // 
            button3.Location = new Point(510, 120);
            button3.Name = "button3";
            button3.Size = new Size(160, 50);
            button3.TabIndex = 3;
            button3.Text = "🏷️ Giá vé";
            button3.UseVisualStyleBackColor = true;

            // 
            // button4 - Bán vé
            // 
            button4.Location = new Point(150, 190);
            button4.Name = "button4";
            button4.Size = new Size(160, 50);
            button4.TabIndex = 4;
            button4.Text = "🎫 Bán vé";
            button4.UseVisualStyleBackColor = true;

            // 
            // button5 - Sơ đồ ghế
            // 
            button5.Location = new Point(330, 190);
            button5.Name = "button5";
            button5.Size = new Size(160, 50);
            button5.TabIndex = 5;
            button5.Text = "🪑 Sơ đồ ghế";
            button5.UseVisualStyleBackColor = true;

            // 
            // button6 - Nhân viên
            // 
            button6.Location = new Point(510, 190);
            button6.Name = "button6";
            button6.Size = new Size(160, 50);
            button6.TabIndex = 6;
            button6.Text = "🧍 Nhân viên";
            button6.UseVisualStyleBackColor = true;

            // 
            // button7 - Thống kê
            // 
            button7.Location = new Point(150, 260);
            button7.Name = "button7";
            button7.Size = new Size(160, 50);
            button7.TabIndex = 7;
            button7.Text = "📊 Thống kê";
            button7.UseVisualStyleBackColor = true;

            // 
            // button8 - Rạp chiếu
            // 
            button8.Location = new Point(330, 260);
            button8.Name = "button8";
            button8.Size = new Size(160, 50);
            button8.TabIndex = 8;
            button8.Text = "🏢 Rạp chiếu";
            button8.UseVisualStyleBackColor = true;

            // 
            // button9 - Đăng xuất
            // 
            button9.Location = new Point(510, 260);
            button9.Name = "button9";
            button9.Size = new Size(160, 50);
            button9.TabIndex = 9;
            button9.Text = "🔒 Đăng xuất";
            button9.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 400);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quản lý rạp chiếu phim";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
