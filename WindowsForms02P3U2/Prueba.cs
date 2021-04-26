using System;
using System.Windows.Forms;

namespace WindowsForms02P3U2
{
    public class Prueba
    {
        public Prueba(int x, ref string resultado)
        {
            string r = Convert.ToString(x);
            resultado = $"Creado objeto Pruebla con x={r}";
        }

        ~Prueba()
        {
            MessageBox.Show("Liberando espacio");
        }
    }
}
