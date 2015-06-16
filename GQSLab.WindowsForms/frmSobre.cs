using System;
using System.Windows.Forms;

namespace GQSLab.WindowsForms
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void frmSobre_Load(object sender, EventArgs e)
        {

        }

        private void frmSobre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
                Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
