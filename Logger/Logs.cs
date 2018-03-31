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

        static private Logs frameLog = null;

        public Logs()
        {
            InitializeComponent();
        }

        public static Logs getInstance()
        {
            if (frameLog == null)
                frameLog = new Logs();

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
