using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App_ToLend.Database;

namespace App_ToLend
{
    public class TolendlistPage : ContentPage
    {
        ListView listView;
        public TolendlistPage()
        {
            //création d'une Listview
            listView = new ListView
            { };
            Content = listView;
        }

            protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            listView.ItemsSource = await App.DB.GetItemsAsync();
        }

    }
}
