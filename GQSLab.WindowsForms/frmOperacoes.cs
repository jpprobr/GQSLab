using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GQSLab.WindowsForms
{
    public partial class frmOperacoes : Form
    {
        public frmOperacoes()
        {
            InitializeComponent();
        }
    }

    public class Operacoes
    {
        public int Soma(int a, int b)
        {
            var resultado = a + b;

            return resultado;
        }

        public int Subtrai(int a, int b)
        {
            var resultado = a - b;

            return resultado;
        }
    }
}
