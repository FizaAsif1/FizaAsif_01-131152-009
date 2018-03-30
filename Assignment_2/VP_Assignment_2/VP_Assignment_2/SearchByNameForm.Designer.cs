namespace VP_Assignment_2
{
    partial class SearchByNameForm
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
            this.searchName_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.searchName_listBox = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchName_lbl
            // 
            this.searchName_lbl.AutoSize = true;
            this.searchName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchName_lbl.Location = new System.Drawing.Point(125, 53);
            this.searchName_lbl.Name = "searchName_lbl";
            this.searchName_lbl.Size = new System.Drawing.Size(136, 15);
            this.searchName_lbl.TabIndex = 4;
            this.searchName_lbl.Text = "Enter Student Name";
            this.searchName_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(56, 94);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(38, 13);
            this.name_lbl.TabIndex = 5;
            this.name_lbl.Text = "Name:";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(114, 90);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(199, 20);
            this.name_txt.TabIndex = 7;
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(265, 143);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 6;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // searchName_listBox
            // 
            this.searchName_listBox.FormattingEnabled = true;
            this.searchName_listBox.Location = new System.Drawing.Point(46, 195);
            this.searchName_listBox.Name = "searchName_listBox";
            this.searchName_listBox.Size = new System.Drawing.Size(294, 121);
            this.searchName_listBox.TabIndex = 8;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // SearchByNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.searchName_listBox);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.searchName_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchByNameForm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchByNameForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchName_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.ListBox searchName_listBox;
        private System.Windows.Forms.Button back_btn;
    }
}