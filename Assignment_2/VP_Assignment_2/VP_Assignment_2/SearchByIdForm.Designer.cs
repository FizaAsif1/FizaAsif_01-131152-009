namespace VP_Assignment_2
{
    partial class SearchID_frm
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
            this.Search_btn = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.searchID_lbl = new System.Windows.Forms.Label();
            this.searchID_listBox = new System.Windows.Forms.ListBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(268, 144);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 0;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(110, 93);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(205, 20);
            this.id_txt.TabIndex = 1;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(66, 96);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(21, 13);
            this.id_lbl.TabIndex = 2;
            this.id_lbl.Text = "ID:";
            this.id_lbl.Click += new System.EventHandler(this.id_lbl_Click);
            // 
            // searchID_lbl
            // 
            this.searchID_lbl.AutoSize = true;
            this.searchID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchID_lbl.Location = new System.Drawing.Point(131, 52);
            this.searchID_lbl.Name = "searchID_lbl";
            this.searchID_lbl.Size = new System.Drawing.Size(116, 15);
            this.searchID_lbl.TabIndex = 3;
            this.searchID_lbl.Text = "Enter Student ID ";
            this.searchID_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchID_listBox
            // 
            this.searchID_listBox.FormattingEnabled = true;
            this.searchID_listBox.Location = new System.Drawing.Point(40, 201);
            this.searchID_listBox.Name = "searchID_listBox";
            this.searchID_listBox.Size = new System.Drawing.Size(303, 108);
            this.searchID_listBox.TabIndex = 4;
            this.searchID_listBox.SelectedIndexChanged += new System.EventHandler(this.searchByID_listBox_SelectedIndexChanged);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // SearchID_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.searchID_listBox);
            this.Controls.Add(this.searchID_lbl);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.Search_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchID_frm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchID_frm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label searchID_lbl;
        private System.Windows.Forms.ListBox searchID_listBox;
        private System.Windows.Forms.Button back_btn;
    }
}