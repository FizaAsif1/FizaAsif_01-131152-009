namespace VP_Assignment_2
{
    partial class InsertDataForm
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
            this.insertScreen_lbl = new System.Windows.Forms.Label();
            this.id_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.semester_lbl = new System.Windows.Forms.Label();
            this.gpa_lbl = new System.Windows.Forms.Label();
            this.department_lbl = new System.Windows.Forms.Label();
            this.university_lbl = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.semester_txt = new System.Windows.Forms.TextBox();
            this.gpa_txt = new System.Windows.Forms.TextBox();
            this.department_txt = new System.Windows.Forms.TextBox();
            this.university_txt = new System.Windows.Forms.TextBox();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertScreen_lbl
            // 
            this.insertScreen_lbl.AutoSize = true;
            this.insertScreen_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertScreen_lbl.Location = new System.Drawing.Point(100, 46);
            this.insertScreen_lbl.Name = "insertScreen_lbl";
            this.insertScreen_lbl.Size = new System.Drawing.Size(182, 15);
            this.insertScreen_lbl.TabIndex = 0;
            this.insertScreen_lbl.Text = "Enter your Personal Details";
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(59, 88);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(21, 13);
            this.id_lbl.TabIndex = 1;
            this.id_lbl.Text = "ID:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(56, 125);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(38, 13);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Name:";
            // 
            // semester_lbl
            // 
            this.semester_lbl.AutoSize = true;
            this.semester_lbl.Location = new System.Drawing.Point(56, 164);
            this.semester_lbl.Name = "semester_lbl";
            this.semester_lbl.Size = new System.Drawing.Size(54, 13);
            this.semester_lbl.TabIndex = 3;
            this.semester_lbl.Text = "Semester:";
            // 
            // gpa_lbl
            // 
            this.gpa_lbl.AutoSize = true;
            this.gpa_lbl.Location = new System.Drawing.Point(59, 200);
            this.gpa_lbl.Name = "gpa_lbl";
            this.gpa_lbl.Size = new System.Drawing.Size(32, 13);
            this.gpa_lbl.TabIndex = 4;
            this.gpa_lbl.Text = "GPA:";
            // 
            // department_lbl
            // 
            this.department_lbl.AutoSize = true;
            this.department_lbl.Location = new System.Drawing.Point(56, 239);
            this.department_lbl.Name = "department_lbl";
            this.department_lbl.Size = new System.Drawing.Size(65, 13);
            this.department_lbl.TabIndex = 5;
            this.department_lbl.Text = "Department:";
            // 
            // university_lbl
            // 
            this.university_lbl.AutoSize = true;
            this.university_lbl.Location = new System.Drawing.Point(56, 276);
            this.university_lbl.Name = "university_lbl";
            this.university_lbl.Size = new System.Drawing.Size(56, 13);
            this.university_lbl.TabIndex = 6;
            this.university_lbl.Text = "University:";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(143, 85);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(171, 20);
            this.id_txt.TabIndex = 7;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(143, 122);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(171, 20);
            this.name_txt.TabIndex = 8;
            // 
            // semester_txt
            // 
            this.semester_txt.Location = new System.Drawing.Point(143, 161);
            this.semester_txt.Name = "semester_txt";
            this.semester_txt.Size = new System.Drawing.Size(171, 20);
            this.semester_txt.TabIndex = 9;
            // 
            // gpa_txt
            // 
            this.gpa_txt.Location = new System.Drawing.Point(143, 197);
            this.gpa_txt.Name = "gpa_txt";
            this.gpa_txt.Size = new System.Drawing.Size(171, 20);
            this.gpa_txt.TabIndex = 10;
            this.gpa_txt.TextChanged += new System.EventHandler(this.gpa_txt_TextChanged);
            // 
            // department_txt
            // 
            this.department_txt.Location = new System.Drawing.Point(143, 236);
            this.department_txt.Name = "department_txt";
            this.department_txt.Size = new System.Drawing.Size(171, 20);
            this.department_txt.TabIndex = 11;
            // 
            // university_txt
            // 
            this.university_txt.Location = new System.Drawing.Point(143, 273);
            this.university_txt.Name = "university_txt";
            this.university_txt.Size = new System.Drawing.Size(171, 20);
            this.university_txt.TabIndex = 12;
            // 
            // Submit_btn
            // 
            this.Submit_btn.Location = new System.Drawing.Point(282, 314);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(75, 23);
            this.Submit_btn.TabIndex = 13;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = true;
            this.Submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(16, 13);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // InsertDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.university_txt);
            this.Controls.Add(this.department_txt);
            this.Controls.Add(this.gpa_txt);
            this.Controls.Add(this.semester_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.university_lbl);
            this.Controls.Add(this.department_lbl);
            this.Controls.Add(this.gpa_lbl);
            this.Controls.Add(this.semester_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.insertScreen_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InsertDataForm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InsertDataForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insertScreen_lbl;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label semester_lbl;
        private System.Windows.Forms.Label gpa_lbl;
        private System.Windows.Forms.Label department_lbl;
        private System.Windows.Forms.Label university_lbl;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox semester_txt;
        private System.Windows.Forms.TextBox gpa_txt;
        private System.Windows.Forms.TextBox department_txt;
        private System.Windows.Forms.TextBox university_txt;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Button back_btn;
    }
}