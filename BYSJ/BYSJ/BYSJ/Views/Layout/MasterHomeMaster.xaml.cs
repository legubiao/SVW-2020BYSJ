using BYSJ.Views.RepairRecord;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BYSJ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterHomeMaster : ContentPage
    {
        public ListView ListView;

        public MasterHomeMaster()
        {
            InitializeComponent();

            BindingContext = new MasterHomeMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterHomeMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterHomeMasterMenuItem> MenuItems { get; set; }

            public MasterHomeMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterHomeMasterMenuItem>(new[]
                {
                    new MasterHomeMasterMenuItem { Id = 0, Title = "账户" ,TargetType = typeof(UserInfo)},
                    new MasterHomeMasterMenuItem { Id = 1, Title = "备件管理" ,TargetType = typeof(PartsManagement)},
                    new MasterHomeMasterMenuItem { Id = 2, Title = "维护管理" ,TargetType = typeof(RepairRecordTabbedPage)},
                    new MasterHomeMasterMenuItem { Id = 2, Title = "库存管理" ,TargetType = typeof(MaintainManagement) },
                    new MasterHomeMasterMenuItem { Id = 3, Title = "维修手册" ,TargetType = typeof(manual)},
                    new MasterHomeMasterMenuItem { Id = 4, Title = "预测" ,TargetType = typeof(Prediction)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}