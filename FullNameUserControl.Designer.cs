namespace BirthdayList
{
    partial class FullNameUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namelabel = new System.Windows.Forms.Label();
            this.lastNamelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(14, 9);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(60, 20);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            // 
            // lastNamelabel
            // 
            this.lastNamelabel.AutoSize = true;
            this.lastNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNamelabel.Location = new System.Drawing.Point(14, 29);
            this.lastNamelabel.Name = "lastNamelabel";
            this.lastNamelabel.Size = new System.Drawing.Size(96, 20);
            this.lastNamelabel.TabIndex = 1;
            this.lastNamelabel.Text = "LastName";
            // 
            // FullNameUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.lastNamelabel);
            this.Controls.Add(this.namelabel);
            this.Name = "FullNameUserControl";
            this.Size = new System.Drawing.Size(127, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label lastNamelabel;
    }
}
