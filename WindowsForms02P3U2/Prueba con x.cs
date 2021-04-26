using System;
using System.Windows.Forms;

namespace WindowsForms02P3U2
{
    public partial class Prueba_con_x : Form
    {
        public Prueba_con_x()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string resultado = "";
            Prueba p = new Prueba(5, ref resultado);
            lblPrueba.Text = resultado;



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
