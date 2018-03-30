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
    public partial class MarkAttendanceForm : Form
    {
        public MarkAttendanceForm()
        {
            InitializeComponent();
        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            string[] result = Student_Profile.fileOps.searchSemester(Convert.ToInt32(semester_txt.Text));
            bool[] attendance = new bool[result.Length];
            

            if(result != null)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] != null)
                    {
                        string[] data = result[i].Split(' ');
                        if (MessageBox.Show(data[0] + " " + data[1] + " is Present?", "Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            attendance[i] = true;
                        }
                        else
                        {
                            attendance[i] = false;
                        }
                    }
                    else
                        break;
                }
            }

            Student_Profile.fileOps.markAttendance(Convert.ToInt32(semester_txt.Text), attendance);

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void MarkAttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
