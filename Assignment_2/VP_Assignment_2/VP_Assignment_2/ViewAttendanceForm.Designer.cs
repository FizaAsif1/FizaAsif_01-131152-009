namespace VP_Assignment_2
{
    partial class ViewAttendanceForm
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
            this.back_btn = new System.Windows.Forms.Button();
            this.viewAttendance_listBox = new System.Windows.Forms.ListBox();
            this.semester_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.semester_lbl = new System.Windows.Forms.Label();
            this.searchName_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // viewAttendance_listBox
            // 
            this.viewAttendance_listBox.FormattingEnabled = true;
            this.viewAttendance_listBox.Location = new System.Drawing.Point(46, 195);
            this.viewAttendance_listBox.Name = "viewAttendance_listBox";
            this.viewAttendance_listBox.Size = new System.Drawing.Size(294, 121);
            this.viewAttendance_listBox.TabIndex = 15;
            // 
            // semester_txt
            // 
            this.semester_txt.Location = new System.Drawing.Point(114, 90);
            this.semester_txt.Name = "semester_txt";
            this.semester_txt.Size = new System.Drawing.Size(199, 20);
            this.semester_txt.TabIndex = 14;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(265, 143);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 13;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Location = new System.Drawing.Point(56, 94);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.Size = new System.Drawing.Size(54, 13);
            this.semester_lbl.TabIndex = 12;
            this.semester_lbl.Text = "Semester:";
            // 
            // searchName_lbl
            // 
            this.searchName_lbl.AutoSize = true;
            this.searchName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchName_lbl.Location = new System.Drawing.Point(125, 50);
            this.searchName_lbl.Name = "searchName_lbl";
            this.searchName_lbl.Size = new System.Drawing.Size(161, 15);
            this.searchName_lbl.TabIndex = 11;
            this.searchName_lbl.Text = "Enter Semester Number";
            this.searchName_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ViewAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.viewAttendance_listBox);
            this.Controls.Add(this.semester_txt);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.searchName_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewAttendanceForm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAttendanceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ListBox viewAttendance_listBox;
        private System.Windows.Forms.TextBox semester_txt;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Label searchName_lbl;
    }
}