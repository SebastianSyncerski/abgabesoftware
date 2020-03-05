using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfCalculator
{
    public static class DwarfLibrary
    {
        public static int GetKitchenValue(int chosenItem)
        {
            switch (chosenItem)
            {
                //depends how many dwarfs can be supported by a single workshop with this production
                case 0: //easy meal
                    return 40;
                case 1: //fine meal
                    return 30;
                case 2: //lavish meal
                    return 15;
                default:
                    return 0;
            }
        }

        public static int GetCraftValue(int chosenItem)
        {
            switch (chosenItem)
            {
                //depends how many rangers can be supported by a single workshop with this production
                case 0: //bone
                    return 19;
                case 1: //wood
                    return 20;
                case 2: //copper
                    return 10;
                case 3: //steel
                    return 8;
                default:
                    return 0;
            }
        }

        public static string GetItemToSmelt(int CraftItemIndex)
        {
            switch (CraftItemIndex)
            {
                //returns item type for smelting depending on what is needed by craftdwarf
                case 0: //bone
                    return "n/a";
                case 1: //wood
                    return "n/a";
                case 2: //copper
                    return "Tetrahedrite";
                case 3: //steel
                    return "Steel";
                default:
                    return "n/a";
            }
        }

        public static int GetSmeltMultiplier(int CraftItemIndex)
        {
            switch (CraftItemIndex)
            {
                //depends how many bolt productions can be supported by a single workshop with this production
                case 0: //bone
                    return 0;
                case 1: //wood
                    return 0;
                case 2: //copper
                    return 3;
                case 3: //steel
                    return 1;
                default:
                    return 0;
            }
        }

        public static int GetFurnaceMultiplier(int CraftItemIndex)
        {
            switch (CraftItemIndex)
            {
                //how many Smelters can be supported by a single workshop with this ingot production
                case 0: //bone
                    return 0;
                case 1: //wood
                    return 0;
                case 2: //copper
                    return 3;
                case 3: //steel
                    return 2;
                default:
                    return 0;
            }
        }

    }
}
