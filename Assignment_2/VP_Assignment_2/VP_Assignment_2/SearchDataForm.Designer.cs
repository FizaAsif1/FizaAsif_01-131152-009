namespace VP_Assignment_2
{
    partial class SearchDataForm
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
            this.searchID_btn = new System.Windows.Forms.Button();
            this.searchName_btn = new System.Windows.Forms.Button();
            this.searchSemester_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchID_btn
            // 
            this.searchID_btn.Location = new System.Drawing.Point(53, 110);
            this.searchID_btn.Name = "searchID_btn";
            this.searchID_btn.Size = new System.Drawing.Size(111, 69);
            this.searchID_btn.TabIndex = 0;
            this.searchID_btn.Text = "Search by ID";
            this.searchID_btn.UseVisualStyleBackColor = true;
            this.searchID_btn.Click += new System.EventHandler(this.searchID_btn_Click);
            // 
            // searchName_btn
            // 
            this.searchName_btn.Location = new System.Drawing.Point(215, 110);
            this.searchName_btn.Name = "searchName_btn";
            this.searchName_btn.Size = new System.Drawing.Size(111, 69);
            this.searchName_btn.TabIndex = 1;
            this.searchName_btn.Text = "Search by Name";
            this.searchName_btn.UseVisualStyleBackColor = true;
            this.searchName_btn.Click += new System.EventHandler(this.searchName_btn_Click);
            // 
            // searchSemester_btn
            // 
            this.searchSemester_btn.Location = new System.Drawing.Point(139, 216);
            this.searchSemester_btn.Name = "searchSemester_btn";
            this.searchSemester_btn.Size = new System.Drawing.Size(111, 69);
            this.searchSemester_btn.TabIndex = 2;
            this.searchSemester_btn.Text = "Search by Semester";
            this.searchSemester_btn.UseVisualStyleBackColor = true;
            this.searchSemester_btn.Click += new System.EventHandler(this.searchSemester_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select your Choice";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // SearchDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchSemester_btn);
            this.Controls.Add(this.searchName_btn);
            this.Controls.Add(this.searchID_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchDataForm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDataForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchID_btn;
        private System.Windows.Forms.Button searchName_btn;
        private System.Windows.Forms.Button searchSemester_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
    }
}