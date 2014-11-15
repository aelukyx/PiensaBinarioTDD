using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaBinario
{
    public class PensandoBinario
    {
        public int GetNumeroDeCombinaciones(int numero)
        {
            return Convert.ToInt32(Math.Pow(2,numero));
        }
    }
}



