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
        public static bool Rendered_Color;
        public static DateTime localDate;
        public TolendItemPage()
        {
             InitializeComponent();
             localDate= DateTime.Now;
        }
        


        async void OnSaveClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new TolendListPage());
            await DisplayAlert("Information", "Enregistrement effectué", "OK");
            
        }



        void OnSpeakClicked(object sender, EventArgs e)
        {
            //var todoItem = (TodoItem)BindingContext;

            //DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
        }

        void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            Choixdate = e.NewDate.ToString();

           // DateTime localDate = e.NewDate; /* .NewDate();*/
            //mainlabeldate.Text = DateTime.Now.ToString();// localDate.ToString();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            //listView.ItemsSource = await App.DB.GetItemsAsync();
        }


        private void switch1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Rendered_Color = switch1.IsToggled;
        }
    }
}