using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collezioni
{
    public class Collezioni
    {
        public static int[] Incremento(int[] a)
        {
            int[] array = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array[i] = a[i] + 10;
            }
            return array;

        
        }
    }
}
