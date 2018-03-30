namespace VP_Assignment_2
{
    partial class listStudentForm
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
            this.List_btn = new System.Windows.Forms.Button();
            this.semester_lbl = new System.Windows.Forms.Label();
            this.listData_lbl = new System.Windows.Forms.Label();
            this.listStudents_listBox = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // semester_txt
            // 
            this.semester_txt.Location = new System.Drawing.Point(119, 100);
            this.semester_txt.Name = "semester_txt";
            this.semester_txt.Size = new System.Drawing.Size(189, 20);
            this.semester_txt.TabIndex = 15;
            // 
            // List_btn
            // 
            this.List_btn.Location = new System.Drawing.Point(261, 150);
            this.List_btn.Name = "List_btn";
            this.List_btn.Size = new System.Drawing.Size(75, 23);
            this.List_btn.TabIndex = 14;
            this.List_btn.Text = "List";
            this.List_btn.UseVisualStyleBackColor = true;
            this.List_btn.Click += new System.EventHandler(this.List_btn_Click);
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Location = new System.Drawing.Point(44, 103);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.Size = new System.Drawing.Size(54, 13);
            this.semester_lbl.TabIndex = 13;
            this.semester_lbl.Text = "Semester:";
            // 
            // listData_lbl
            // 
            this.listData_lbl.AutoSize = true;
            this.listData_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listData_lbl.Location = new System.Drawing.Point(116, 64);
            this.listData_lbl.Name = "listData_lbl";
            this.listData_lbl.Size = new System.Drawing.Size(161, 15);
            this.listData_lbl.TabIndex = 12;
            this.listData_lbl.Text = "Enter Semester Number";
            this.listData_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listStudents_listBox
            // 
            this.listStudents_listBox.FormattingEnabled = true;
            this.listStudents_listBox.Location = new System.Drawing.Point(47, 209);
            this.listStudents_listBox.Name = "listStudents_listBox";
            this.listStudents_listBox.Size = new System.Drawing.Size(289, 108);
            this.listStudents_listBox.TabIndex = 16;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 18;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // listStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.listStudents_listBox);
            this.Controls.Add(this.semester_txt);
            this.Controls.Add(this.List_btn);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.listData_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "listStudentForm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.listStudentForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox semester_txt;
        private System.Windows.Forms.Button List_btn;
        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Label listData_lbl;
        private System.Windows.Forms.ListBox listStudents_listBox;
        private System.Windows.Forms.Button back_btn;
    }
}