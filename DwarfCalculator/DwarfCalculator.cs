using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfCalculator
{
    class Calculator
    {
        public int KitchenOutput;
        public int FarmerOutput;
        public int CraftOutput;
        public int SmelterOutput;
        public string SmelterItemOutput;
        public int WoodOutput;
        public Calculator(int dwarfCount, int KitchenMultiplier, int CraftMultiplier)
        {
            KitchenOutput = DwarfMath.KitchenCalc(dwarfCount, KitchenMultiplier);

        }
    }
}
