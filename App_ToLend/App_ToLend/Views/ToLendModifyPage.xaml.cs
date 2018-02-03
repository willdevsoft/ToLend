using App_ToLend.Models;
using App_ToLend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_ToLend.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToLendModifyPage : ContentPage
    {
        public static string ChoixDateModify;
        public ToLendModifyPage()
        {
            InitializeComponent();
            
           var image = new Image() ;
         //   var binding = new Xamarin.Forms.Binding() { Source = this.BindingContext };
            
        }





        async void Button_Modify(object sender, EventArgs e)
        {

            var vm2 = new TLModifyViewModel();
            var button = sender as Button;
            var tolendItem = button.BindingContext as TolendItem;
            vm2.ModifyCommand.Execute(tolendItem);
            await Navigation.PushAsync(new TolendListPage());
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            ChoixDateModify = e.NewDate.ToString();
        }

        async void Button_Cancel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TolendListPage());


        }
    }
}