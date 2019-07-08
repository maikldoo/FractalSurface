namespace FractalGorizontLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landscape));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LandscapePictureBox = new System.Windows.Forms.PictureBox();
            this.point2y_textbox = new System.Windows.Forms.TextBox();
            this.point2x_textbox = new System.Windows.Forms.TextBox();
            this.point1y_textbox = new System.Windows.Forms.TextBox();
            this.point1x_textbox = new System.Windows.Forms.TextBox();
            this.FirP = new System.Windows.Forms.Label();
            this.SecP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.roughness_textbox = new System.Windows.Forms.TextBox();
            this.Paint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandscapePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.LandscapePictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 692);
            this.panel1.TabIndex = 0;
            // 
            // LandscapePictureBox
            // 
            this.LandscapePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.LandscapePictureBox.Location = new System.Drawing.Point(0, 0);
            this.LandscapePictureBox.Name = "LandscapePictureBox";
            this.LandscapePictureBox.Size = new System.Drawing.Size(1500, 700);
            this.LandscapePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LandscapePictureBox.TabIndex = 0;
            this.LandscapePictureBox.TabStop = false;
            // 
            // point2y_textbox
            // 
            this.point2y_textbox.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.point2y_textbox.Location = new System.Drawing.Point(1306, 289);
            this.point2y_textbox.Name = "point2y_textbox";
            this.point2y_textbox.Size = new System.Drawing.Size(100, 38);
            this.point2y_textbox.TabIndex = 1;
            this.point2y_textbox.Text = "0";
            this.point2y_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // point2x_textbox
            // 
            this.point2x_textbox.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.point2x_textbox.Location = new System.Drawing.Point(1186, 289);
            this.point2x_textbox.Name = "point2x_textbox";
            this.point2x_textbox.Size = new System.Drawing.Size(100, 38);
            this.point2x_textbox.TabIndex = 2;
            this.point2x_textbox.Text = "1500";
            this.point2x_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // point1y_textbox
            // 
            this.point1y_textbox.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.point1y_textbox.Location = new System.Drawing.Point(1315, 149);
            this.point1y_textbox.Name = "point1y_textbox";
            this.point1y_textbox.Size = new System.Drawing.Size(100, 38);
            this.point1y_textbox.TabIndex = 3;
            this.point1y_textbox.Text = "0";
            this.point1y_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // point1x_textbox
            // 
            this.point1x_textbox.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.point1x_textbox.Location = new System.Drawing.Point(1186, 149);
            this.point1x_textbox.Name = "point1x_textbox";
            this.point1x_textbox.Size = new System.Drawing.Size(100, 38);
            this.point1x_textbox.TabIndex = 4;
            this.point1x_textbox.Text = "0";
            this.point1x_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FirP
            // 
            this.FirP.AutoSize = true;
            this.FirP.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirP.Location = new System.Drawing.Point(1187, 82);
            this.FirP.Name = "FirP";
            this.FirP.Size = new System.Drawing.Size(228, 64);
            this.FirP.TabIndex = 5;
            this.FirP.Text = "Coordinates of\r\nfirst point";
            this.FirP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecP
            // 
            this.SecP.AutoSize = true;
            this.SecP.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.SecP.Location = new System.Drawing.Point(1180, 222);
            this.SecP.Name = "SecP";
            this.SecP.Size = new System.Drawing.Size(235, 64);
            this.SecP.TabIndex = 6;
            this.SecP.Text = "Coordinates of \r\nsecond point";
            this.SecP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.label3.Location = new System.Drawing.Point(1213, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Settings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.R.Location = new System.Drawing.Point(1214, 361);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(172, 64);
            this.R.TabIndex = 8;
            this.R.Text = "Roughness\r\nparameter";
            this.R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roughness_textbox
            // 
            this.roughness_textbox.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.roughness_textbox.Location = new System.Drawing.Point(1186, 428);
            this.roughness_textbox.Name = "roughness_textbox";
            this.roughness_textbox.Size = new System.Drawing.Size(229, 38);
            this.roughness_textbox.TabIndex = 9;
            this.roughness_textbox.Text = "0,5";
            this.roughness_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Paint
            // 
            this.Paint.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Paint.Location = new System.Drawing.Point(1186, 632);
            this.Paint.Name = "Paint";
            this.Paint.Size = new System.Drawing.Size(229, 60);
            this.Paint.TabIndex = 12;
            this.Paint.Text = "Paint";
            this.Paint.UseVisualStyleBackColor = true;
            this.Paint.Click += new System.EventHandler(this.Paint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1202, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 64);
            this.label1.TabIndex = 13;
            this.label1.Text = "Terrain type:\r\nhills, peaks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(1186, 568);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 38);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "hills";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Landscape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1458, 711);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Paint);
            this.Controls.Add(this.roughness_textbox);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecP);
            this.Controls.Add(this.FirP);
            this.Controls.Add(this.point1x_textbox);
            this.Controls.Add(this.point1y_textbox);
            this.Controls.Add(this.point2x_textbox);
            this.Controls.Add(this.point2y_textbox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Landscape";
            this.Text = "Landscape";
            this.Load += new System.EventHandler(this.Landscape_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LandscapePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LandscapePictureBox;
        private System.Windows.Forms.TextBox point2y_textbox;
        private System.Windows.Forms.TextBox point2x_textbox;
        private System.Windows.Forms.TextBox point1y_textbox;
        private System.Windows.Forms.TextBox point1x_textbox;
        private System.Windows.Forms.Label FirP;
        private System.Windows.Forms.Label SecP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.TextBox roughness_textbox;
        private System.Windows.Forms.Button Paint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

