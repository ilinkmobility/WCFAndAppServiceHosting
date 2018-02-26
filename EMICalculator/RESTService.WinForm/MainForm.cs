using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTService.WinForm
{
    public partial class MainForm : Form
    {
        static MainForm mainForm;

        public MainForm()
        {
            InitializeComponent();

            mainForm = this;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RESTServer.Instance.StartService();
        }

        public static void SetRequestMessage(string data)
        {
            mainForm.richTextBoxRequest.Text = data;
        }

        public static void SetResponseMessage(string data)
        {
            mainForm.richTextBoxResponse.Text = data;
        }

        public static void SetLastServed(string dateTime)
        {
            mainForm.labelLastServed.Text = "Last Served : " + dateTime;
        }
    }
}
