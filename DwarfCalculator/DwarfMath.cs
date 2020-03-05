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
            Multiplier = DwarfLibrary.GetKitchenValue(Multiplier);
            if (Multiplier > 0)
            {
                return (Dwarfs % Multiplier == 0) ? Dwarfs / Multiplier : (int)(Dwarfs / Multiplier) + 1;
            }
            else return 0;

        }
        public static int FarmCalc(int Kitchens)
        {
            return (Kitchens % 2 == 0) ? Kitchens / 2 : (int)(Kitchens / 2) + 1;
        }
        public static int CraftCalc(int Rangers, int Multiplier)
        {
            Multiplier = DwarfLibrary.GetCraftValue(Multiplier);
            if (Multiplier > 0)
            {
                return (Rangers % Multiplier == 0) ? Rangers / Multiplier : (int)(Rangers / Multiplier) + 1;
            }
            else return 0;
        }
        public static int SmeltCalc(int Multiplier, int CraftShops)
        {
            Multiplier = DwarfLibrary.GetSmeltMultiplier(Multiplier);
            if (Multiplier > 0)
            {
                return (CraftShops % Multiplier == 0) ? CraftShops / Multiplier : (int)(CraftShops / Multiplier) + 1;
            }
            else return 0;
        }

        public static int FurnaceCalc(int SmeltType, int Smelters)
        {
            SmeltType = DwarfLibrary.GetFurnaceMultiplier(SmeltType);
            if (SmeltType > 0)
            {
                return (Smelters % SmeltType == 0) ? Smelters / SmeltType : (int)(Smelters / SmeltType) + 1;
            }
            else return 0;
        }
    }
}
