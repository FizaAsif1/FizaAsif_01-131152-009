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
    
    public partial class SearchByNameForm : Form
    {
        public SearchByNameForm()
        {
            InitializeComponent();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(name_txt.Text);
            searchName_listBox.Items.Clear();
            string[] result = Student_Profile.fileOps.searchName(name);
            for (int i = 0; i <= result.Length;i++ )
            {
                if(result[i] != null)
                {
                    searchName_listBox.Items.Add(result[i]);
                }
                else
                    break;
            }
                
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchDataForm form = new SearchDataForm();
            form.Show();
        }

        private void SearchByNameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thankyou for using Student Profile", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
