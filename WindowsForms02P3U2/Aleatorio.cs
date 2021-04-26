using System;
using System.Windows.Forms;

namespace WindowsForms02P3U2
{
    public class Aleatorio
    {
        private int[] numeros;
        Random rd = new Random();
        public Aleatorio()
        {
            ImprimeAleatorio();
        }

        ~Aleatorio()
        {
            MessageBox.Show("Liberando espacio");
        }

        public int[] Numeros { get => numeros; set => numeros = value; }

        public void ImprimeAleatorio()
        {
            Numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Numeros[i] = rd.Next(0, 250);
            }
        }
    }
}
