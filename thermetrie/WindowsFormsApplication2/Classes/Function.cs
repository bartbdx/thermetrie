using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Classes
{
    class Function
    {
        internal static string slugify(String name)
        {
            return Regex.Replace(name, "[^a-z0-9\\._\\s]", "", RegexOptions.IgnoreCase);
        }


        internal static decimal PlusGrandeValeur(List<decimal> L)
        {
            decimal max = 0;
            foreach (decimal line in L)
            {
                if (line > max)
                {
                    max = line;
                }
            }
            return max;
        }

        internal static decimal PlusPetiteValeur(List<decimal> L)
        {
            decimal min = L[0];
            foreach (decimal line in L)
            {
                if (line < min)
                {
                    min = line;
                }
            }
            return min;
        }

        internal static decimal valeurMoyenne(List<decimal> L)
        {
            decimal moy = 0;
            foreach (decimal line in L)
            {
                moy += line;
            }
            moy = moy / L.Count;
            return moy;
        }
    }
}
