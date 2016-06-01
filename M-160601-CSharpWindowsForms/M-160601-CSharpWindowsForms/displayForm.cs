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
    public partial class displayForm : Form
    {
        private List<Users> userEntry;

        public displayForm(List<Users> userEntry)
        {
            InitializeComponent();
            this.userEntry = userEntry;
        }

        private void displayForm_Load(object sender, EventArgs e)
        {
             
            gvUserDetails.DataSource = userEntry;
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            var user = userEntry.OrderByDescending(x => x.Index).ToList();

            gvUserDetails.DataSource = user;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var user = userEntry.OrderBy(x => x.Index).ToList();

            gvUserDetails.DataSource = user;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {

            Visible = false;
            Form1 firstForm = new Form1();
            firstForm.Show();
        }
    }
}
