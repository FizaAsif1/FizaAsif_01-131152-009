namespace VP_Assignment_2
{
    partial class MainForm
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
            this.Create_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.ListTop_btn = new System.Windows.Forms.Button();
            this.MarkAttendance_btn = new System.Windows.Forms.Button();
            this.ViewAttendance_btn = new System.Windows.Forms.Button();
            this.mainScreen_lbl = new System.Windows.Forms.Label();
            this.main_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(59, 96);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(97, 58);
            this.Create_btn.TabIndex = 0;
            this.Create_btn.Text = "Create Student Profile";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(221, 96);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(97, 58);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search Student Record";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(59, 186);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(97, 58);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "Delete Student Record";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // ListTop_btn
            // 
            this.ListTop_btn.Location = new System.Drawing.Point(221, 186);
            this.ListTop_btn.Name = "ListTop_btn";
            this.ListTop_btn.Size = new System.Drawing.Size(97, 58);
            this.ListTop_btn.TabIndex = 3;
            this.ListTop_btn.Text = "List Top 3 Students";
            this.ListTop_btn.UseVisualStyleBackColor = true;
            this.ListTop_btn.Click += new System.EventHandler(this.ListTop_btn_Click);
            // 
            // MarkAttendance_btn
            // 
            this.MarkAttendance_btn.Location = new System.Drawing.Point(59, 281);
            this.MarkAttendance_btn.Name = "MarkAttendance_btn";
            this.MarkAttendance_btn.Size = new System.Drawing.Size(97, 58);
            this.MarkAttendance_btn.TabIndex = 4;
            this.MarkAttendance_btn.Text = "Mark Student Attendance";
            this.MarkAttendance_btn.UseVisualStyleBackColor = true;
            this.MarkAttendance_btn.Click += new System.EventHandler(this.MarkAttendance_btn_Click);
            // 
            // ViewAttendance_btn
            // 
            this.ViewAttendance_btn.Location = new System.Drawing.Point(221, 281);
            this.ViewAttendance_btn.Name = "ViewAttendance_btn";
            this.ViewAttendance_btn.Size = new System.Drawing.Size(97, 58);
            this.ViewAttendance_btn.TabIndex = 5;
            this.ViewAttendance_btn.Text = "View Student Attendance";
            this.ViewAttendance_btn.UseVisualStyleBackColor = true;
            this.ViewAttendance_btn.Click += new System.EventHandler(this.ViewAttendance_btn_Click);
            // 
            // mainScreen_lbl
            // 
            this.mainScreen_lbl.AutoSize = true;
            this.mainScreen_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreen_lbl.Location = new System.Drawing.Point(128, 59);
            this.mainScreen_lbl.Name = "mainScreen_lbl";
            this.mainScreen_lbl.Size = new System.Drawing.Size(124, 15);
            this.mainScreen_lbl.TabIndex = 6;
            this.mainScreen_lbl.Text = "Select your choice";
            this.mainScreen_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // main_lbl
            // 
            this.main_lbl.AutoSize = true;
            this.main_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_lbl.Location = new System.Drawing.Point(116, 18);
            this.main_lbl.Name = "main_lbl";
            this.main_lbl.Size = new System.Drawing.Size(146, 24);
            this.main_lbl.TabIndex = 7;
            this.main_lbl.Text = "Student Profile";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.main_lbl);
            this.Controls.Add(this.mainScreen_lbl);
            this.Controls.Add(this.ViewAttendance_btn);
            this.Controls.Add(this.MarkAttendance_btn);
            this.Controls.Add(this.ListTop_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Create_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_frm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button ListTop_btn;
        private System.Windows.Forms.Button MarkAttendance_btn;
        private System.Windows.Forms.Button ViewAttendance_btn;
        private System.Windows.Forms.Label mainScreen_lbl;
        private System.Windows.Forms.Label main_lbl;
    }
}

