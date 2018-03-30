namespace VP_Assignment_2
{
    partial class SearchBySemesterForm
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
            this.semester_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.semester_lbl = new System.Windows.Forms.Label();
            this.searchSemester_lbl = new System.Windows.Forms.Label();
            this.searchSemester_listBox = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // semester_txt
            // 
            this.semester_txt.Location = new System.Drawing.Point(117, 98);
            this.semester_txt.Name = "semester_txt";
            this.semester_txt.Size = new System.Drawing.Size(207, 20);
            this.semester_txt.TabIndex = 11;
            this.semester_txt.TextChanged += new System.EventHandler(this.semester_txt_TextChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(267, 146);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 10;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Location = new System.Drawing.Point(45, 101);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.Size = new System.Drawing.Size(54, 13);
            this.semester_lbl.TabIndex = 9;
            this.semester_lbl.Text = "Semester:";
            // 
            // searchSemester_lbl
            // 
            this.searchSemester_lbl.AutoSize = true;
            this.searchSemester_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSemester_lbl.Location = new System.Drawing.Point(114, 63);
            this.searchSemester_lbl.Name = "searchSemester_lbl";
            this.searchSemester_lbl.Size = new System.Drawing.Size(161, 15);
            this.searchSemester_lbl.TabIndex = 8;
            this.searchSemester_lbl.Text = "Enter Semester Number";
            this.searchSemester_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchSemester_listBox
            // 
            this.searchSemester_listBox.FormattingEnabled = true;
            this.searchSemester_listBox.Location = new System.Drawing.Point(48, 196);
            this.searchSemester_listBox.Name = "searchSemester_listBox";
            this.searchSemester_listBox.Size = new System.Drawing.Size(294, 121);
            this.searchSemester_listBox.TabIndex = 12;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // SearchBySemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.searchSemester_listBox);
            this.Controls.Add(this.semester_txt);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.searchSemester_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchBySemesterForm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchBySemesterForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox semester_txt;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Label searchSemester_lbl;
        private System.Windows.Forms.ListBox searchSemester_listBox;
        private System.Windows.Forms.Button back_btn;
    }
}