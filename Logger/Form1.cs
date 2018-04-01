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
    public partial class frmMain : Form
    {
        private static long count = 1;
        public frmMain()
        {
            InitializeComponent();
            Logs.getInstance().addEntry("start program..");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (tbxName.Text == "")
            {
                Logs.getInstance().addEntry("clicked ok button..");
                return;
            }

            Logs.getInstance().addEntry("entered new name...");
            MessageBox.Show("Beautiful name! It has "+ tbxName.TextLength + " letters.", "Information", MessageBoxButtons.OK);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            Logs.getInstance().addEntry("cleared textbox..");
        }

        private void gelbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            menuStrip1.BackColor = Color.DarkOrange;
            Logs.getInstance().addEntry("changed colour to yellow..");
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void blauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
            menuStrip1.BackColor = Color.DarkOrange;
            Logs.getInstance().addEntry("changed colour to blue..");
        }

        private void grauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkMagenta;
            menuStrip1.BackColor = Color.DarkOrange;
            Logs.getInstance().addEntry("changend colour to magenta..");
        }

        private void grünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGreen;
            menuStrip1.BackColor = Color.DarkOrange;
            Logs.getInstance().addEntry("changend colour to green..");
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            menuStrip1.BackColor = Color.FloralWhite;
            Logs.getInstance().addEntry("changend colour to standard..");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(count % 2 == 0)
            {
                Logs.getInstance().Hide();
                Logs.getInstance().addEntry("closed logs..");
            }
            else
            {
                Logs.getInstance().addEntry("opened logs..");
                Logs.getInstance().Show();
            }
            count++;
            
        }

        private void coulourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void llToFrmAge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Age frmAge = new Age(this);
            frmAge.Show();
        }
    }
}
