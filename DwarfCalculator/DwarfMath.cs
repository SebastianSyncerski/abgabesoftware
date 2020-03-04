using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfCalculator
{
    public static class DwarfMath
    {
        public static int KitchenCalc(int Dwarfs, int Multiplier)
        {
            return (Dwarfs % Multiplier == 0) ? Dwarfs / Multiplier : (int)(Dwarfs / Multiplier) + 1;
            
        }
    }
}
