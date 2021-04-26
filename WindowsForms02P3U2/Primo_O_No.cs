using System.Windows.Forms;

namespace WindowsForms02P3U2
{
    public class Primo
    {
        public int a = 0;
        public Primo(int NumPrimo)
        {
            //pruebaggfgfg
            for (int i = 1; i <= NumPrimo; i++)
            {
                if (NumPrimo % i == 0)
                {
                    a++;
                }

            }

        }

        public void ImprimePrimo()
        {
            if (a > 2)
            {
                MessageBox.Show("No es primo");
            }
            else
            {
                MessageBox.Show("Es primo");

            }

        }

        ~Primo()
        {
            MessageBox.Show("Liberando espacio");
        }
    }
}
