namespace BirthdayList
{
    partial class Form1
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.show_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.period_panel = new System.Windows.Forms.Panel();
            this.all_rb = new System.Windows.Forms.RadioButton();
            this.month_rb = new System.Windows.Forms.RadioButton();
            this.week_rd = new System.Windows.Forms.RadioButton();
            this.show_panel = new System.Windows.Forms.Panel();
            this.sun_panel = new System.Windows.Forms.Panel();
            this.Sun_lb = new System.Windows.Forms.Label();
            this.sat_panel = new System.Windows.Forms.Panel();
            this.sat_lb = new System.Windows.Forms.Label();
            this.wed_panel = new System.Windows.Forms.Panel();
            this.wed_lb = new System.Windows.Forms.Label();
            this.fri_panel = new System.Windows.Forms.Panel();
            this.fri_lb = new System.Windows.Forms.Label();
            this.thu_panel = new System.Windows.Forms.Panel();
            this.thu_lb = new System.Windows.Forms.Label();
            this.tue_panel = new System.Windows.Forms.Panel();
            this.tue_lb = new System.Windows.Forms.Label();
            this.mon_panel = new System.Windows.Forms.Panel();
            this.mon_lb = new System.Windows.Forms.Label();
            this.mon_date_lb = new System.Windows.Forms.Label();
            this.tu_date_lb = new System.Windows.Forms.Label();
            this.wed_date_lb = new System.Windows.Forms.Label();
            this.thur_date_lb = new System.Windows.Forms.Label();
            this.fri_date_lb = new System.Windows.Forms.Label();
            this.sat_date_lb = new System.Windows.Forms.Label();
            this.sun_date_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.period_panel.SuspendLayout();
            this.show_panel.SuspendLayout();
            this.sun_panel.SuspendLayout();
            this.sat_panel.SuspendLayout();
            this.wed_panel.SuspendLayout();
            this.fri_panel.SuspendLayout();
            this.thu_panel.SuspendLayout();
            this.tue_panel.SuspendLayout();
            this.mon_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.show_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.period_panel);
            this.panel1.Location = new System.Drawing.Point(1447, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(4, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 371);
            this.panel2.TabIndex = 3;
            // 
            // show_btn
            // 
            this.show_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.show_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(3, 83);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(294, 76);
            this.show_btn.TabIndex = 2;
            this.show_btn.Text = "SHOW";
            this.show_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(3, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(294, 74);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // period_panel
            // 
            this.period_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.period_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.period_panel.Controls.Add(this.all_rb);
            this.period_panel.Controls.Add(this.month_rb);
            this.period_panel.Controls.Add(this.week_rd);
            this.period_panel.Location = new System.Drawing.Point(3, 542);
            this.period_panel.Name = "period_panel";
            this.period_panel.Size = new System.Drawing.Size(294, 155);
            this.period_panel.TabIndex = 0;
            // 
            // all_rb
            // 
            this.all_rb.AutoSize = true;
            this.all_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_rb.Location = new System.Drawing.Point(26, 108);
            this.all_rb.Name = "all_rb";
            this.all_rb.Size = new System.Drawing.Size(50, 24);
            this.all_rb.TabIndex = 2;
            this.all_rb.TabStop = true;
            this.all_rb.Text = "all";
            this.all_rb.UseVisualStyleBackColor = true;
            this.all_rb.CheckedChanged += new System.EventHandler(this.all_rb_CheckedChanged);
            // 
            // month_rb
            // 
            this.month_rb.AutoSize = true;
            this.month_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_rb.Location = new System.Drawing.Point(26, 64);
            this.month_rb.Name = "month_rb";
            this.month_rb.Size = new System.Drawing.Size(81, 24);
            this.month_rb.TabIndex = 1;
            this.month_rb.Text = "month";
            this.month_rb.UseVisualStyleBackColor = true;
            this.month_rb.CheckedChanged += new System.EventHandler(this.month_rb_CheckedChanged);
            // 
            // week_rd
            // 
            this.week_rd.AutoSize = true;
            this.week_rd.Checked = true;
            this.week_rd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week_rd.Location = new System.Drawing.Point(26, 22);
            this.week_rd.Name = "week_rd";
            this.week_rd.Size = new System.Drawing.Size(72, 24);
            this.week_rd.TabIndex = 0;
            this.week_rd.TabStop = true;
            this.week_rd.Text = "week";
            this.week_rd.UseVisualStyleBackColor = true;
            this.week_rd.CheckedChanged += new System.EventHandler(this.week_rd_CheckedChanged);
            // 
            // show_panel
            // 
            this.show_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.show_panel.Controls.Add(this.sun_panel);
            this.show_panel.Controls.Add(this.sat_panel);
            this.show_panel.Controls.Add(this.wed_panel);
            this.show_panel.Controls.Add(this.fri_panel);
            this.show_panel.Controls.Add(this.thu_panel);
            this.show_panel.Controls.Add(this.tue_panel);
            this.show_panel.Controls.Add(this.mon_panel);
            this.show_panel.Location = new System.Drawing.Point(1, 1);
            this.show_panel.Name = "show_panel";
            this.show_panel.Size = new System.Drawing.Size(1440, 700);
            this.show_panel.TabIndex = 1;
            //
            // show_panel_month
            //
            //this.show_panel_month.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            //this.show_panel_month.Location = new System.Drawing.Point(1, 1);
            //this.show_panel_month.Name = "show_panel_month";
            //this.show_panel_month.Size = new System.Drawing.Size(1440, 700);
            // 
            // sun_panel
            // 
            this.sun_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sun_panel.Controls.Add(this.sun_date_lb);
            this.sun_panel.Controls.Add(this.Sun_lb);
            this.sun_panel.Location = new System.Drawing.Point(1237, 0);
            this.sun_panel.Name = "sun_panel";
            this.sun_panel.Size = new System.Drawing.Size(200, 700);
            this.sun_panel.TabIndex = 6;
            // 
            // Sun_lb
            // 
            this.Sun_lb.AutoSize = true;
            this.Sun_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sun_lb.Location = new System.Drawing.Point(3, 5);
            this.Sun_lb.Name = "Sun_lb";
            this.Sun_lb.Size = new System.Drawing.Size(59, 16);
            this.Sun_lb.TabIndex = 0;
            this.Sun_lb.Text = "Sunday";
            // 
            // sat_panel
            // 
            this.sat_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.sat_panel.Controls.Add(this.sat_date_lb);
            this.sat_panel.Controls.Add(this.sat_lb);
            this.sat_panel.Location = new System.Drawing.Point(1031, 3);
            this.sat_panel.Name = "sat_panel";
            this.sat_panel.Size = new System.Drawing.Size(200, 700);
            this.sat_panel.TabIndex = 5;
            // 
            // sat_lb
            // 
            this.sat_lb.AutoSize = true;
            this.sat_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat_lb.Location = new System.Drawing.Point(3, 2);
            this.sat_lb.Name = "sat_lb";
            this.sat_lb.Size = new System.Drawing.Size(69, 16);
            this.sat_lb.TabIndex = 0;
            this.sat_lb.Text = "Saturday";
            // 
            // wed_panel
            // 
            this.wed_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.wed_panel.Controls.Add(this.wed_date_lb);
            this.wed_panel.Controls.Add(this.wed_lb);
            this.wed_panel.Location = new System.Drawing.Point(413, 3);
            this.wed_panel.Name = "wed_panel";
            this.wed_panel.Size = new System.Drawing.Size(200, 700);
            this.wed_panel.TabIndex = 2;
            // 
            // wed_lb
            // 
            this.wed_lb.AutoSize = true;
            this.wed_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wed_lb.Location = new System.Drawing.Point(3, 2);
            this.wed_lb.Name = "wed_lb";
            this.wed_lb.Size = new System.Drawing.Size(90, 16);
            this.wed_lb.TabIndex = 0;
            this.wed_lb.Text = "Wednesday";
            // 
            // fri_panel
            // 
            this.fri_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.fri_panel.Controls.Add(this.fri_date_lb);
            this.fri_panel.Controls.Add(this.fri_lb);
            this.fri_panel.Location = new System.Drawing.Point(825, 3);
            this.fri_panel.Name = "fri_panel";
            this.fri_panel.Size = new System.Drawing.Size(200, 700);
            this.fri_panel.TabIndex = 4;
            // 
            // fri_lb
            // 
            this.fri_lb.AutoSize = true;
            this.fri_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fri_lb.Location = new System.Drawing.Point(3, 2);
            this.fri_lb.Name = "fri_lb";
            this.fri_lb.Size = new System.Drawing.Size(51, 16);
            this.fri_lb.TabIndex = 0;
            this.fri_lb.Text = "Friday";
            // 
            // thu_panel
            // 
            this.thu_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.thu_panel.Controls.Add(this.thur_date_lb);
            this.thu_panel.Controls.Add(this.thu_lb);
            this.thu_panel.Location = new System.Drawing.Point(619, 3);
            this.thu_panel.Name = "thu_panel";
            this.thu_panel.Size = new System.Drawing.Size(200, 700);
            this.thu_panel.TabIndex = 3;
            // 
            // thu_lb
            // 
            this.thu_lb.AutoSize = true;
            this.thu_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thu_lb.Location = new System.Drawing.Point(3, 2);
            this.thu_lb.Name = "thu_lb";
            this.thu_lb.Size = new System.Drawing.Size(72, 16);
            this.thu_lb.TabIndex = 0;
            this.thu_lb.Text = "Thursday";
            // 
            // tue_panel
            // 
            this.tue_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tue_panel.Controls.Add(this.tu_date_lb);
            this.tue_panel.Controls.Add(this.tue_lb);
            this.tue_panel.Location = new System.Drawing.Point(207, 3);
            this.tue_panel.Name = "tue_panel";
            this.tue_panel.Size = new System.Drawing.Size(200, 700);
            this.tue_panel.TabIndex = 1;
            // 
            // tue_lb
            // 
            this.tue_lb.AutoSize = true;
            this.tue_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tue_lb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tue_lb.Location = new System.Drawing.Point(3, 2);
            this.tue_lb.Name = "tue_lb";
            this.tue_lb.Size = new System.Drawing.Size(68, 16);
            this.tue_lb.TabIndex = 0;
            this.tue_lb.Text = "Tuesday";
            // 
            // mon_panel
            // 
            this.mon_panel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.mon_panel.Controls.Add(this.mon_date_lb);
            this.mon_panel.Controls.Add(this.mon_lb);
            this.mon_panel.Location = new System.Drawing.Point(3, 0);
            this.mon_panel.Name = "mon_panel";
            this.mon_panel.Size = new System.Drawing.Size(200, 700);
            this.mon_panel.TabIndex = 0;
            // 
            // mon_lb
            // 
            this.mon_lb.AutoSize = true;
            this.mon_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon_lb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mon_lb.Location = new System.Drawing.Point(3, 5);
            this.mon_lb.Name = "mon_lb";
            this.mon_lb.Size = new System.Drawing.Size(62, 16);
            this.mon_lb.TabIndex = 0;
            this.mon_lb.Text = "Monday";
            // 
            // mon_date_lb
            // 
            this.mon_date_lb.AutoSize = true;
            this.mon_date_lb.Location = new System.Drawing.Point(105, 5);
            this.mon_date_lb.Name = "mon_date_lb";
            this.mon_date_lb.Size = new System.Drawing.Size(44, 16);
            this.mon_date_lb.TabIndex = 1;
            this.mon_date_lb.Text = "label1";
            // 
            // tu_date_lb
            // 
            this.tu_date_lb.AutoSize = true;
            this.tu_date_lb.Location = new System.Drawing.Point(105, 2);
            this.tu_date_lb.Name = "tu_date_lb";
            this.tu_date_lb.Size = new System.Drawing.Size(44, 16);
            this.tu_date_lb.TabIndex = 1;
            this.tu_date_lb.Text = "label1";
            // 
            // wed_date_lb
            // 
            this.wed_date_lb.AutoSize = true;
            this.wed_date_lb.Location = new System.Drawing.Point(113, 2);
            this.wed_date_lb.Name = "wed_date_lb";
            this.wed_date_lb.Size = new System.Drawing.Size(44, 16);
            this.wed_date_lb.TabIndex = 1;
            this.wed_date_lb.Text = "label1";
            // 
            // thur_date_lb
            // 
            this.thur_date_lb.AutoSize = true;
            this.thur_date_lb.Location = new System.Drawing.Point(103, 2);
            this.thur_date_lb.Name = "thur_date_lb";
            this.thur_date_lb.Size = new System.Drawing.Size(44, 16);
            this.thur_date_lb.TabIndex = 1;
            this.thur_date_lb.Text = "label1";
            // 
            // fri_date_lb
            // 
            this.fri_date_lb.AutoSize = true;
            this.fri_date_lb.Location = new System.Drawing.Point(99, 2);
            this.fri_date_lb.Name = "fri_date_lb";
            this.fri_date_lb.Size = new System.Drawing.Size(44, 16);
            this.fri_date_lb.TabIndex = 1;
            this.fri_date_lb.Text = "label1";
            // 
            // sat_date_lb
            // 
            this.sat_date_lb.AutoSize = true;
            this.sat_date_lb.Location = new System.Drawing.Point(109, 2);
            this.sat_date_lb.Name = "sat_date_lb";
            this.sat_date_lb.Size = new System.Drawing.Size(44, 16);
            this.sat_date_lb.TabIndex = 1;
            this.sat_date_lb.Text = "label1";
            // 
            // sun_date_lb
            // 
            this.sun_date_lb.AutoSize = true;
            this.sun_date_lb.Location = new System.Drawing.Point(92, 5);
            this.sun_date_lb.Name = "sun_date_lb";
            this.sun_date_lb.Size = new System.Drawing.Size(44, 16);
            this.sun_date_lb.TabIndex = 1;
            this.sun_date_lb.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 700);
            this.Controls.Add(this.show_panel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "BirthdayList";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.period_panel.ResumeLayout(false);
            this.period_panel.PerformLayout();
            this.show_panel.ResumeLayout(false);
            this.sun_panel.ResumeLayout(false);
            this.sun_panel.PerformLayout();
            this.sat_panel.ResumeLayout(false);
            this.sat_panel.PerformLayout();
            this.wed_panel.ResumeLayout(false);
            this.wed_panel.PerformLayout();
            this.fri_panel.ResumeLayout(false);
            this.fri_panel.PerformLayout();
            this.thu_panel.ResumeLayout(false);
            this.thu_panel.PerformLayout();
            this.tue_panel.ResumeLayout(false);
            this.tue_panel.PerformLayout();
            this.mon_panel.ResumeLayout(false);
            this.mon_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel period_panel;
        private System.Windows.Forms.RadioButton month_rb;
        private System.Windows.Forms.RadioButton week_rd;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.RadioButton all_rb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel show_panel;
        private System.Windows.Forms.Panel show_panel_month;
        private System.Windows.Forms.Panel sun_panel;
        private System.Windows.Forms.Panel sat_panel;
        private System.Windows.Forms.Panel fri_panel;
        private System.Windows.Forms.Panel thu_panel;
        private System.Windows.Forms.Panel wed_panel;
        private System.Windows.Forms.Panel tue_panel;
        private System.Windows.Forms.Panel mon_panel;
        private System.Windows.Forms.Label mon_lb;
        private System.Windows.Forms.Label tue_lb;
        private System.Windows.Forms.Label wed_lb;
        private System.Windows.Forms.Label thu_lb;
        private System.Windows.Forms.Label fri_lb;
        private System.Windows.Forms.Label sat_lb;
        private System.Windows.Forms.Label Sun_lb;
        private System.Windows.Forms.Label mon_date_lb;
        private System.Windows.Forms.Label tu_date_lb;
        private System.Windows.Forms.Label wed_date_lb;
        private System.Windows.Forms.Label thur_date_lb;
        private System.Windows.Forms.Label fri_date_lb;
        private System.Windows.Forms.Label sat_date_lb;
        private System.Windows.Forms.Label sun_date_lb;
    }
}

