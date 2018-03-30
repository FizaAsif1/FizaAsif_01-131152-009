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
    public partial class ViewAttendanceForm : Form
    {
        public ViewAttendanceForm()
        {
            InitializeComponent();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            viewAttendance_listBox.Items.Clear();
            string[] data = Student_Profile.fileOps.viewAttendance(Convert.ToInt32(semester_txt.Text));
            for(int i=0;i<data.Length;i++)
            {
                if(data[i]!=null)
                {
                    viewAttendance_listBox.Items.Add(data[i]);
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void ViewAttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
