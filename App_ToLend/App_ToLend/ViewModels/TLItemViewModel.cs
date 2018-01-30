﻿using App_ToLend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App_ToLend.Views;
using App_ToLend.ViewModels;

namespace App_ToLend.ViewModels
{
    public class TLItemViewModel
    {
        public TolendItem tolendItem { get; set; }


        public TLItemViewModel()
        {
            tolendItem = new TolendItem()
            {

            };

        }

        public Command SaveCommand
        {
            get
            {
                return new Command(async () => 
                {
                    tolendItem.DateSelected = App_ToLend.Views.TolendItemPage.Choixdate;
                    await App.DB.SaveItemAsync(tolendItem);

                });
            }
        }
        public Command<TolendItem> RemoveCommand
        {
            get
            {
                return new Command<TolendItem>(async (tolendItem) =>
                {
                    await App.DB.DeleteItemAsync(tolendItem);
                });
            }
        }

    }
}
