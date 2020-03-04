using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;

namespace DwarfCalculator.ViewModels
{
    [POCOViewModel]
    public class MainWindowVM
    {
        //public virtual ObservableCollection<string> KitchenItems { get; set; } = new ObservableCollection<string>() {"", "", "", "" };
        [BindableProperty]
        public virtual int KitchenItemIndex { get; set; } = 0;
        [BindableProperty]
        public virtual int CraftItemIndex { get; set; } = 0;
        [BindableProperty]
        public virtual string KitchenWorkshops { get; set; } = "0";
        [BindableProperty]
        public virtual string FarmerWorkshops { get; set; } = "0";
        [BindableProperty]
        public virtual string CraftWorkshops { get; set; } = "0";
        [BindableProperty]
        public virtual string SmelterWorkshops { get; set; } = "0";
        [BindableProperty]
        public virtual string SmelterItemWorkshops { get; set; } = "0";
        [BindableProperty]
        public virtual string FurnaceWorkshops { get; set; } = "0";
        [BindableProperty(OnPropertyChangedMethodName = nameof(CheckInputValidity))]
        public virtual string DwarfcountInput { get; set; } = "";
        [BindableProperty(OnPropertyChangedMethodName = nameof(CheckInputValidity))]
        public virtual string RangercountInput { get; set; } = "";
        [BindableProperty]
        public virtual bool ButtonEnabled { get; set; } = false;

        public MainWindowVM()
        {

        }

        public void OnCalculate()
        {
            if (!int.TryParse(DwarfcountInput, out int dwarfsAvailable)) return;

            Calculator calc = new Calculator(dwarfsAvailable, 10, 12);

            KitchenWorkshops = calc.KitchenOutput.ToString();
            CraftWorkshops = CraftItemIndex.ToString();
        }
        public void CheckInputValidity()
        {
            if (int.TryParse(RangercountInput, out int i) && int.TryParse(DwarfcountInput, out int n))
            {
                ButtonEnabled = true;
            }
            else ButtonEnabled = false;
        }
        protected int GetKitchenItemValue(int itemIndex)
        {
            switch (itemIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    return 0;
            }
            return 0;
        }
    }
}
