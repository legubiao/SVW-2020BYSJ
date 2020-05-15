using BYSJ.Models;
using BYSJ.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BYSJ.Views.RepairRecord
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UnfinishedRecord : ContentPage
    {
        public UnfinishedRecord()
        {
            InitializeComponent();           
        }
       
        void OnTap(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new RecordDetail((repairRecord)e.SelectedItem));
        }
        public void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;            
            list.IsRefreshing = false;
        }
    }
}