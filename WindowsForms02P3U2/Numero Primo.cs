using System;
using System.Windows.Forms;

namespace WindowsForms02P3U2
{
    public partial class Numero_Primo : Form
    {
        public Numero_Primo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int NumPrimo = int.Parse(txtNum.Text);
            Primo ObjP = new Primo(NumPrimo);
            ObjP.ImprimePrimo();
        }
    }
}
