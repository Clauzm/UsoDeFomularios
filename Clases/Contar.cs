using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsoDeFormularios.Clases
{
    public class Contar
    {
        public int ContarCaracteres(string mensaje)
        {
            
            var cuenta = 0;

            for (int i = 0; i < mensaje.Length; i++)

            {
                var actual = mensaje[i];

                if (actual >= '0' && actual <= '9' || actual >= 'a' && actual <= 'z' || actual >= 'A' && actual <= 'Z')
                {

                }

                else cuenta++;

            }

            return cuenta;
        }

    }
}
