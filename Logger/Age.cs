using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger
{
    public partial class Age : Form
    {
        public Age()
        {
            InitializeComponent();
            Logs.getInstance().addEntry("opened frame 'age'..");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(tbxAge.Text == "")
            {
                Logs.getInstance().addEntry("no age typed in ..");
                return;
            }

            if (!parseOK())
            {
                Logs.getInstance().addEntry("typed incorrect age..");
                return;
            }
            else
            {
                Logs.getInstance().addEntry("typed age..");
                int age = Int32.Parse(tbxAge.Text);
                if(age < 1)
                {
                    Logs.getInstance().addEntry("typed value smaller than 1..");
                    MessageBox.Show("Are you really younger than one year?", "Information", MessageBoxButtons.OK);
                    return;
                }

                DateTime aDate = DateTime.Now;
                //Logs.getInstance().addEntry("typed age..");
                MessageBox.Show("You could have been borned in " + (aDate.Year - age) + ".","Information",MessageBoxButtons.OK);
                

            }
                

            
        }

        private bool parseOK()
        {
            try
            {
                int i = Int32.Parse(tbxAge.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Logs.getInstance().Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Logs.getInstance().addEntry("cleared textbox 'age'..");
            tbxAge.Text = "";
        }

        private void Age_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {   
            Logs.getInstance().addEntry("frame 'age' closed..");
            Dispose();
        }
    }
}
