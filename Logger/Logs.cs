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
    public partial class Logs : Form
    {

        private static  Logs frameLog = new Logs();

        private Logs()
        {
            InitializeComponent();
        }

        public static Logs getInstance()
        {
            return frameLog;
        }

        public void addEntry(String aString)
        {
            DateTime aDate = DateTime.Now;
            tbxLog.AppendText(aDate.ToShortDateString() + " " + aDate.ToLongTimeString() + ": " + aString +
                Environment.NewLine);

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logs_Load(object sender, EventArgs e)
        {

        }
    }
}
