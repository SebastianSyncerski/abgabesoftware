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
        public virtual string SmithyWorkshops { get; set; } = "0";
        [BindableProperty]
        public virtual int SmithyItemIndex { get; set; } = 0;
        [BindableProperty]
        public virtual int SmithyMaterialIndex { get; set; } = 0;
        [BindableProperty]
        public virtual string SmelterWorkshops { get; set; } = "0";
        [BindableProperty]
        public virtual string SmelterItem { get; set; } = "";
        [BindableProperty]
        public virtual string FurnaceWorkshops { get; set; } = "0";

        [BindableProperty(OnPropertyChangedMethodName = nameof(CheckInputValidity))]
        public virtual string DwarfcountInput { get; set; } = "";

        [BindableProperty]
        public virtual string RangercountInput { get; set; } = "";

        [BindableProperty]
        public virtual string WarriorcountInput { get; set; } = "";

        [BindableProperty]
        public virtual bool ButtonEnabled { get; set; } = false;

        public MainWindowVM()
        {

        }

        public void OnCalculate()
        {
            if (!int.TryParse(DwarfcountInput, out int dwarfsAvailable)) return;
            if (!int.TryParse(RangercountInput, out int rangersAvailable)) RangercountInput = "0";

            Calculator calc = new Calculator(dwarfsAvailable,rangersAvailable, KitchenItemIndex, CraftItemIndex);

            KitchenWorkshops = calc.KitchenOutput;
            FarmerWorkshops = calc.FarmerOutput;
            CraftWorkshops = calc.CraftOutput;
            SmelterWorkshops = calc.SmelterOutput;
            SmelterItem = calc.SmelterItemInput;
            FurnaceWorkshops = calc.FurnaceOutput;

        }
        public void CheckInputValidity()
        {
            int.TryParse(RangercountInput, out int rangersAvailable);
            if (int.TryParse(DwarfcountInput, out int n) && n >= rangersAvailable)
            {
                ButtonEnabled = true;
            }
            else ButtonEnabled = false;
        }
        
    }
}
