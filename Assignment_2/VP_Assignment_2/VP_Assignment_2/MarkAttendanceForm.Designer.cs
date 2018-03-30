namespace VP_Assignment_2
{
    partial class MarkAttendanceForm
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
            this.Select_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.semester_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // semester_txt
            // 
            this.semester_txt.Location = new System.Drawing.Point(105, 78);
            this.semester_txt.Name = "semester_txt";
            this.semester_txt.Size = new System.Drawing.Size(199, 20);
            this.semester_txt.TabIndex = 11;
            // 
            // Select_btn
            // 
            this.Select_btn.Location = new System.Drawing.Point(256, 131);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(75, 23);
            this.Select_btn.TabIndex = 10;
            this.Select_btn.Text = "Select";
            this.Select_btn.UseVisualStyleBackColor = true;
            this.Select_btn.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(47, 82);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(54, 13);
            this.name_lbl.TabIndex = 9;
            this.name_lbl.Text = "Semester:";
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_lbl.Location = new System.Drawing.Point(116, 41);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.Size = new System.Drawing.Size(161, 15);
            this.semester_lbl.TabIndex = 8;
            this.semester_lbl.Text = "Enter Semester Number";
            this.semester_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // MarkAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 183);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.semester_txt);
            this.Controls.Add(this.Select_btn);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.semester_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MarkAttendanceForm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MarkAttendanceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox semester_txt;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Button back_btn;
    }
}