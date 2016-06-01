using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_160601_CSharpWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        List<Users> userEntry=null;
        private void Form1_Load(object sender, EventArgs e)
        {
           userEntry = new List<Users>();
           AcceptButton = btnAdd;

            btnAdd.TabStop = false;
            btnContinue.TabStop = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtEntry.Text) || string.IsNullOrWhiteSpace(txtSur.Text) || txtEntry.Text.Length < 3 || txtSur.Text.Length < 3)
            {

                MessageBox.Show("This entry is not valid. Please enter a name in both textboxes");
            }
            else
            {
                Users user = new Users(userEntry.Count)
                {

                    FirstName = txtEntry.Text,
                    SurName = txtSur.Text,
                };

                userEntry.Add(user);

                txtEntry.Text = "";
                txtSur.Text = "";
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            Visible = false;
            displayForm display = new displayForm(userEntry);
            display.Show();
        }
    }
}
