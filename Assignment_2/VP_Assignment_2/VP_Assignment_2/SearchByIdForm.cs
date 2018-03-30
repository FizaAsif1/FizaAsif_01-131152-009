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
    public partial class SearchID_frm : Form
    {
        
        public SearchID_frm()
        {
            InitializeComponent();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(id_txt.Text);
            searchID_listBox.Items.Clear();
            searchID_listBox.Items.Add(Student_Profile.fileOps.searchID(id));
        }

        private void id_lbl_Click(object sender, EventArgs e)
        {

        }

        private void searchByID_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchDataForm form = new SearchDataForm();
            form.Show();
            //if(MessageBox.Show("Do you want to exit?","Exit",MessageBoxButtons.OKCancel)==DialogResult.OK)
            //    Application.Exit();
        }

        private void SearchID_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
