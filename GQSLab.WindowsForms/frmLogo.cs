using System;
using System.Drawing;
using System.Windows.Forms;

namespace GQSLab.WindowsForms
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void frmLogo_Resize(object sender, EventArgs e)
        {
            labelInfoSistema.Location = new Point((this.Width / 2) - (labelInfoSistema.Width / 2), labelInfoSistema.Location.Y);
        }
    }
}
