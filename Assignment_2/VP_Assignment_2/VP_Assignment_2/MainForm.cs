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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertDataForm form = new InsertDataForm();
            form.Show();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchDataForm form = new SearchDataForm();
            form.Show();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteData_frm form = new DeleteData_frm();
            form.Show();
        }

        private void ListTop_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            listStudentForm form = new listStudentForm();
            form.Show();
        }


        private void Main_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MarkAttendance_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarkAttendanceForm form = new MarkAttendanceForm();
            form.Show();
        }

        private void ViewAttendance_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAttendanceForm form = new ViewAttendanceForm();
            form.Show();
        }
    }
}
