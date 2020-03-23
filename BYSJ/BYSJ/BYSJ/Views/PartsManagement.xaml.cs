using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BYSJ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PartsManagement : ContentPage
    {
        public PartsManagement()
        {
            InitializeComponent();
        }

        void Search_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "查询按钮被点击了！", "OK");
        }

        void Add_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "添加备件按钮被点击了！", "OK");
        }

        void Modify_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "修改备件记录被点击了！", "OK");
        }
    }
}