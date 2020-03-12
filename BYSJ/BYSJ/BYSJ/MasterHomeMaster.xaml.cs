﻿using System;
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
                    new MasterHomeMasterMenuItem { Id = 0, Title = "用户信息" ,TargetType = typeof(UserInfo)},
                    new MasterHomeMasterMenuItem { Id = 1, Title = "备件管理" ,TargetType = typeof(PartsManagement)},
                    new MasterHomeMasterMenuItem { Id = 2, Title = "维护记录" ,TargetType = typeof(MaintainManagement) },
                    new MasterHomeMasterMenuItem { Id = 3, Title = "常见故障" ,TargetType = typeof(manual)},
                    new MasterHomeMasterMenuItem { Id = 4, Title = "库存预测" ,TargetType = typeof(Prediction)},
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