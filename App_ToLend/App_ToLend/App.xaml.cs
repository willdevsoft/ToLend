using App_ToLend.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App_ToLend
{
    public partial class App : Application
    {
        static TolendItemDatabase database;

        public App()
        {
            InitializeComponent();

            //database = new TolendItemDatabase("TodoSQLite.db3");
            MainPage = new App_ToLend.Views.MenuPage();
        }


 
        // TodoItemDatabase
        public static TolendItemDatabase DB
        {
            get
            {
                if (database == null)
                {
                    //database = new TolendItemDatabase("TolendSQLite.db3");
                    database = new TolendItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("DB_ToLend_SQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }

    

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
