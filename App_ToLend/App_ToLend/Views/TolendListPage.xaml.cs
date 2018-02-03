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
    public partial class TolendListPage : ContentPage
    {
        //ListView listView;
        public TolendListPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            listView.ItemsSource = await App.DB.GetItemsAsync();

        }

        private async Task Remove_Clicked(object sender, EventArgs e)
        {

            var button = sender as Button;
            var tolendItem=button.BindingContext as TolendItem;
            var vm = new TLItemViewModel();
            vm.RemoveCommand.Execute(tolendItem);
            listView.ItemsSource = await App.DB.GetItemsAsync();
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            await Navigation.PushAsync(new ToLendModifyPage
            {
                BindingContext = e.SelectedItem as TolendItem
        });
        }

        private async void New_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TolendItemPage());

        }
    }
}