using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmContactLog = new FrmContactLog();

            frmContactLog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmSalesLog = new FrmSalesLog();

            frmSalesLog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmEditClient = new FrmEditClient();

            frmEditClient.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frmSettings = new FrmSettings();

            frmSettings.ShowDialog();
        }
    }
}
