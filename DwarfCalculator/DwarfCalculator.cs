using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfCalculator
{
    class Calculator
    {
        public string KitchenOutput = "";
        public string FarmerOutput = "";
        public string CraftOutput = "";
        public string SmelterOutput = "";
        public string SmelterItemInput = "";
        public string FurnaceOutput = "";
        private string ErrorMessage = "N/A";
        public Calculator(int DwarfCount,int RangerCount, int KitchenItemIndex, int CraftItemIndex)
        {
            int resultTEMP = DwarfMath.KitchenCalc(DwarfCount, KitchenItemIndex);
            KitchenOutput = resultTEMP.ToString();
            FarmerOutput = DwarfMath.FarmCalc(resultTEMP).ToString();
            resultTEMP = DwarfMath.CraftCalc(RangerCount, CraftItemIndex);
            CraftOutput = resultTEMP.ToString();
            SmelterItemInput = DwarfLibrary.GetItemToSmelt(CraftItemIndex);
            SmelterOutput = DwarfMath.SmeltCalc(CraftItemIndex, resultTEMP).ToString();
            if (int.TryParse(SmelterOutput, out int n))
            {
                resultTEMP = int.Parse(SmelterOutput);
                FurnaceOutput = DwarfMath.FurnaceCalc(CraftItemIndex, resultTEMP).ToString();
            }
            else FurnaceOutput = "0";

            FinishCalc();
        }

        private void FinishCalc()
        {
            if (KitchenOutput == "")
            {
                KitchenOutput = ErrorMessage;
            }
            if (FarmerOutput == "")
            {
                FarmerOutput = ErrorMessage;
            }
            if (CraftOutput == "")
            {
                CraftOutput = ErrorMessage;
            }
            if (SmelterOutput == "")
            {
                SmelterOutput = ErrorMessage;
            }
            if (SmelterItemInput == "")
            {
                SmelterItemInput = ErrorMessage;
            }
            if (FurnaceOutput == "")
            {
                FurnaceOutput = ErrorMessage;
            }
        }
    }
}
