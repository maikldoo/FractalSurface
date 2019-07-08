namespace DiamodSquare
{
    partial class Landscape
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Settings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.height1_textbox = new System.Windows.Forms.TextBox();
            this.height4_textbox = new System.Windows.Forms.TextBox();
            this.Paint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.height2_textbox = new System.Windows.Forms.TextBox();
            this.height3_textbox = new System.Windows.Forms.TextBox();
            this.roughness_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LandscapePictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandscapePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.Font = new System.Drawing.Font("Calibri Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.Location = new System.Drawing.Point(1509, 9);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(221, 73);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1425, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "Left-top \r\npoint height";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1425, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 82);
            this.label2.TabIndex = 3;
            this.label2.Text = "Right-down\r\npoint height";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // height1_textbox
            // 
            this.height1_textbox.Font = new System.Drawing.Font("Calibri", 34.2F, System.Drawing.FontStyle.Bold);
            this.height1_textbox.Location = new System.Drawing.Point(1686, 198);
            this.height1_textbox.Name = "height1_textbox";
            this.height1_textbox.Size = new System.Drawing.Size(134, 77);
            this.height1_textbox.TabIndex = 5;
            this.height1_textbox.Text = "0";
            this.height1_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // height4_textbox
            // 
            this.height4_textbox.Font = new System.Drawing.Font("Calibri", 34.2F, System.Drawing.FontStyle.Bold);
            this.height4_textbox.Location = new System.Drawing.Point(1686, 580);
            this.height4_textbox.Name = "height4_textbox";
            this.height4_textbox.Size = new System.Drawing.Size(134, 77);
            this.height4_textbox.TabIndex = 6;
            this.height4_textbox.Text = "0";
            this.height4_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Paint
            // 
            this.Paint.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paint.Location = new System.Drawing.Point(1411, 814);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(409, 134);
            this.Paint.TabIndex = 8;
            this.Paint.Text = "Paint";
            this.Paint.UseVisualStyleBackColor = true;
            this.Paint.Click += new System.EventHandler(this.Paint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1425, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 82);
            this.label4.TabIndex = 11;
            this.label4.Text = "Right-top\r\npoint height";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1425, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 82);
            this.label5.TabIndex = 12;
            this.label5.Text = "Left-down\r\npoint height";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // height2_textbox
            // 
            this.height2_textbox.Font = new System.Drawing.Font("Calibri", 34.2F, System.Drawing.FontStyle.Bold);
            this.height2_textbox.Location = new System.Drawing.Point(1686, 324);
            this.height2_textbox.Name = "height2_textbox";
            this.height2_textbox.Size = new System.Drawing.Size(134, 77);
            this.height2_textbox.TabIndex = 13;
            this.height2_textbox.Text = "0";
            this.height2_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // height3_textbox
            // 
            this.height3_textbox.Font = new System.Drawing.Font("Calibri", 34.2F, System.Drawing.FontStyle.Bold);
            this.height3_textbox.Location = new System.Drawing.Point(1686, 453);
            this.height3_textbox.Name = "height3_textbox";
            this.height3_textbox.Size = new System.Drawing.Size(134, 77);
            this.height3_textbox.TabIndex = 14;
            this.height3_textbox.Text = "0";
            this.height3_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // roughness_textbox
            // 
            this.roughness_textbox.Font = new System.Drawing.Font("Calibri", 34.2F, System.Drawing.FontStyle.Bold);
            this.roughness_textbox.Location = new System.Drawing.Point(1686, 706);
            this.roughness_textbox.Name = "roughness_textbox";
            this.roughness_textbox.Size = new System.Drawing.Size(134, 77);
            this.roughness_textbox.TabIndex = 7;
            this.roughness_textbox.Text = "0,3";
            this.roughness_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1425, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 82);
            this.label3.TabIndex = 4;
            this.label3.Text = "Roughness\r\nparameter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.LandscapePictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1398, 965);
            this.panel1.TabIndex = 15;
            // 
            // LandscapePictureBox
            // 
            this.LandscapePictureBox.Location = new System.Drawing.Point(0, 0);
            this.LandscapePictureBox.Name = "LandscapePictureBox";
            this.LandscapePictureBox.Size = new System.Drawing.Size(1025, 1025);
            this.LandscapePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LandscapePictureBox.TabIndex = 0;
            this.LandscapePictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1476, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 35);
            this.label6.TabIndex = 16;
            this.label6.Text = "Color scheme by height";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.label7.Location = new System.Drawing.Point(1491, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "Black-Blue-Green-Red";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 50.8F);
            this.label8.Location = new System.Drawing.Point(1747, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 104);
            this.label8.TabIndex = 18;
            this.label8.Text = ")";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 50.8F);
            this.label9.Location = new System.Drawing.Point(1432, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 104);
            this.label9.TabIndex = 19;
            this.label9.Text = "(";
            // 
            // Landscape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 977);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.height3_textbox);
            this.Controls.Add(this.height2_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Paint);
            this.Controls.Add(this.roughness_textbox);
            this.Controls.Add(this.height4_textbox);
            this.Controls.Add(this.height1_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "Landscape";
            this.Text = "Landscape";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandscapePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox height1_textbox;
        private System.Windows.Forms.TextBox height4_textbox;
        private System.Windows.Forms.Button Paint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox height2_textbox;
        private System.Windows.Forms.TextBox height3_textbox;
        private System.Windows.Forms.TextBox roughness_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LandscapePictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

