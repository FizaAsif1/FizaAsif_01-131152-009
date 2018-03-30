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
    public partial class listStudentForm : Form
    {
        public listStudentForm()
        {
            InitializeComponent();
        }

        private void List_btn_Click(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(semester_txt.Text);
            string[] result = Student_Profile.fileOps.listTopStudents(semester);
            for(int i=0; i< result.Length; i++)
            {
                if (result[i] != null)
                    listStudents_listBox.Items.Add(result[i]);
                else
                    break;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void listStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
