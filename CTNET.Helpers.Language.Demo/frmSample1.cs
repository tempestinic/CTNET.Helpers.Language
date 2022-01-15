using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTNET.Helpers.Language.Test
{
    public partial class frmSample1 : Form
    {
        public frmSample1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TranslateUI();
        }

        private void TranslateUI()
        {
            this.Text = "frmSample1.Text".Translate();
            button1.Text = "Generic.butAdd".Translate();
            button2.Text = "Generic.butCancel".Translate();
            button3.Text = "Generic.butDelete".Translate();
            button4.Text = "Generic.butRemove".Translate();
        }
    }
}
