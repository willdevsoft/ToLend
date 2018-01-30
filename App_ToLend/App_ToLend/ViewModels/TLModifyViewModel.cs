using App_ToLend.Models;
using App_ToLend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_ToLend.ViewModels
{

    class TLModifyViewModel
    {
        public TolendItem tolendItem { get; set; }


        public TLModifyViewModel()
        {
            tolendItem = new TolendItem()
            {

            };
         }

        public Command<TolendItem> ModifyCommand
        {
            get
            {
                return new Command<TolendItem>(async (tolendItem) =>
                {
                    var testvar = tolendItem.Name;
                    tolendItem.DateSelected = App_ToLend.Views.ToLendModifyPage.ChoixDateModify;
                    await App.DB.SaveItemAsync(tolendItem);
                });
            }


    }
    }
}
