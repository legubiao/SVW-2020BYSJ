using System;
using BYSJ.Services;
using Xamarin.Forms;

namespace BYSJ.Views
{
    public partial class LoginPage : ContentPage
    {
        string account;
        string password;

        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false); //隐藏导航栏
        }

        private async void login_Clicked(object sender, EventArgs e)
        {
            //string token = await RestService.GetToken(account, password);
            //f (token != null)
            //DisplayAlert("验证成功", "服务器返回的token为："+token, "OK");
            Navigation.PushAsync(new MasterHome());
            /*
            SQL_Class database = new SQL_Class();
            if (database.IDCHeck(account, password))
            {
                Navigation.PushAsync(new MasterHome());
            }
            else
            {
                DisplayAlert("Alert", "Invalid password", "OK");
            }
            */
        }

        private void AccountInput(Entry sender, TextChangedEventArgs e)
        {
            this.account = sender.Text.ToString();
        }

        private void PasswordInput(Entry sender, TextChangedEventArgs e)
        {
            this.password = sender.Text.ToString();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
