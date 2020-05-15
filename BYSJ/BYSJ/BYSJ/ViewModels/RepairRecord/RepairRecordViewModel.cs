using BYSJ.Models;
using BYSJ.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BYSJ.ViewModels
{
    class RepairRecordViewModel
    {
        public ObservableCollection<repairRecord> Records { get; set; }
        List<repairRecord> source;

        public RepairRecordViewModel()
        {
            source = Task.Run(()=>RestService.GetUnfinishedRecord()).Result;
            Records = new ObservableCollection<repairRecord>(source);

            RefreshCommand = new Command(() =>
            {
                source = Task.Run(() => RestService.GetUnfinishedRecord()).Result;
                Records = new ObservableCollection<repairRecord>(source);
            });
        }

        public Command RefreshCommand { get; }
        public void OnRefresh(object sender, EventArgs e)
        {
            var list = (ListView)sender;
            //put your refreshing logic here
            source = Task.Run(() => RestService.GetUnfinishedRecord()).Result;
            Records = new ObservableCollection<repairRecord>(source);
            //make sure to end the refresh state
            list.IsRefreshing = false;
        }
    }
}
