using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BYSJ.Models;

namespace BYSJ.Views.RepairRecord
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordDetail : ContentPage
    {
        public repairRecord record { get; set; }
        public string orderNumber;
        public RecordDetail(repairRecord record)
        {
            this.record = record;
            orderNumber = record.orderNumber;
            InitializeComponent();
        }
    }
}