using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_2
{
    public partial class InsertDataForm : Form
    {
        public InsertDataForm()
        {
            InitializeComponent();
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(id_txt.Text);
            string name = Convert.ToString(name_txt.Text);
            int semester = Convert.ToInt32(semester_txt.Text);
            float gpa = float.Parse(gpa_txt.Text);
            string department = Convert.ToString(department_txt.Text);
            string university = Convert.ToString(university_txt.Text);
            Student_Profile.fileOps.WriteToFile(id, name, semester, gpa, department, university);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void InsertDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gpa_txt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
