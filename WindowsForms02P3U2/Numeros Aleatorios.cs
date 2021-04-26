using System;
using System.Windows.Forms;

namespace WindowsForms02P3U2
{
    public partial class Numeros_Aleatorios : Form
    {
        public Numeros_Aleatorios()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            //instanciar
            Aleatorio Obja = new Aleatorio();
            var TraerArreglo = Obja.Numeros;
            foreach (var item in TraerArreglo)
            {
                lstDatos.Items.Add(item);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
