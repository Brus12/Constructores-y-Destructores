using System;
using System.Windows.Forms;

namespace WindowsForms02P3U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboSeleccionar.SelectedIndex = 0;
        }

        private void btnEjec_Click(object sender, EventArgs e)
        {
            Form fmr = null;
            switch (cboSeleccionar.SelectedIndex)
            {
                case 1:
                    fmr = new Numeros_Aleatorios();

                    break;
                case 2:
                    fmr = new Numero_Primo();
                    break;
                case 0:
                    fmr = new Prueba_con_x();
                    break;
                default:
                    break;
            }
            Hide();
            fmr?.ShowDialog();
            Show();
            fmr.Dispose();
        }
    }
}
