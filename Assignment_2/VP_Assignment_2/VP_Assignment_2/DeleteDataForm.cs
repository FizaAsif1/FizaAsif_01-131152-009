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
    public partial class DeleteData_frm : Form
    {
        public DeleteData_frm()
        {
            InitializeComponent();
        }

        private void deleteData_lbl_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(id_txt.Text);
            Student_Profile.fileOps.deleteData(id);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void DeleteData_frm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteData_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
