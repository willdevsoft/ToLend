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
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
            //this.Master = new Master();
            this.Detail = new NavigationPage(new TolendListPage());
        }
        private void NewItem_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TolendItemPage());
            IsPresented = false;
        }
        private void Archives_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TolendListPage());
            IsPresented = false;
        }
    }
}