using App_ToLend.Models;
using App_ToLend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace App_ToLend.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TolendItemPage : ContentPage
    {
        public static string Choixdate;
        public TolendItemPage()
        {
             InitializeComponent();
        }
        


        async void OnSaveClicked(object sender, EventArgs e)
        {
            //var tolendItem = (TolendItem)BindingContext;
            //await App.DB.SaveItemAsync(tolendItem);
            //await Navigation.PopAsync();
            await Navigation.PushAsync(new TolendListPage());
            //var button = sender as Button;
            //var tolendItem = button.BindingContext as TolendItem;
            //tolendItem.Photo = PathLabel.Text;
            //var vm = new TLItemViewModel();
            //vm.SaveCommand.Execute(tolendItem);
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            //var todoItem = (TodoItem)BindingContext;
            //await App.Database.DeleteItemAsync(todoItem);
            //await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            // await Navigation.PopAsync();
            await Navigation.PushAsync(new TolendListPage());

        }

        void OnSpeakClicked(object sender, EventArgs e)
        {
            //var todoItem = (TodoItem)BindingContext;

            //DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
        }

        void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Choixdate = e.NewDate.ToString();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            //listView.ItemsSource = await App.DB.GetItemsAsync();
        }



       
    }
}