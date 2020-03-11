using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BYSJ
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string account;
        string password;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SQL_Class database = new SQL_Class();
            if (database.IDCHeck(account, password))
            {
                DisplayAlert("Alert", "Login Success", "OK");
            }
            else
            {
                DisplayAlert("Alert", "Invalid password", "OK");
            }
        }

        private void AccountInput(Entry sender, TextChangedEventArgs e)
        {
            this.account = sender.Text.ToString();
        }

        private void PasswordInput(Entry sender, TextChangedEventArgs e)
        {
            this.password = sender.Text.ToString();
        }
    }
}
