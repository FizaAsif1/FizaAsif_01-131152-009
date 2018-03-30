namespace VP_Assignment_2
{
    partial class DeleteData_frm
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
            this.id_txt = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.id_lbl = new System.Windows.Forms.Label();
            this.deleteData_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(109, 102);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(175, 20);
            this.id_txt.TabIndex = 11;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(283, 154);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(51, 105);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(21, 13);
            this.id_lbl.TabIndex = 9;
            this.id_lbl.Text = "ID:";
            // 
            // deleteData_lbl
            // 
            this.deleteData_lbl.AutoSize = true;
            this.deleteData_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteData_lbl.Location = new System.Drawing.Point(137, 55);
            this.deleteData_lbl.Name = "deleteData_lbl";
            this.deleteData_lbl.Size = new System.Drawing.Size(112, 15);
            this.deleteData_lbl.TabIndex = 8;
            this.deleteData_lbl.Text = "Enter Student ID";
            this.deleteData_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteData_lbl.Click += new System.EventHandler(this.deleteData_lbl_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 13;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // DeleteData_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.deleteData_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteData_frm";
            this.Text = "Student Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteData_frm_FormClosing);
            this.Load += new System.EventHandler(this.DeleteData_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label deleteData_lbl;
        private System.Windows.Forms.Button back_btn;
    }
}