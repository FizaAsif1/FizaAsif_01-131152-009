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
    public partial class SearchDataForm : Form
    {
        public SearchDataForm()
        {
            InitializeComponent();
        }

        private void searchID_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchID_frm form = new SearchID_frm();
            form.Show();
        }

        private void searchName_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchByNameForm form = new SearchByNameForm();
            form.Show();
        }

        private void searchSemester_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchBySemesterForm form = new SearchBySemesterForm();
            form.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void SearchDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
