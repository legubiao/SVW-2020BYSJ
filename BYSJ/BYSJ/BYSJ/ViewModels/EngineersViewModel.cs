using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using BYSJ.Models;

namespace BYSJ.ViewModels
{
    public class EngineersViewModel : INotifyPropertyChanged
    {
        readonly IList<Engineer> source;
        public ObservableCollection<Engineer> Engineers { get; private set; }

        public EngineersViewModel()
        {
            source = new List<Engineer>();
            CreateMethods();
        }

        void CreateMethods()
        {
            //Methods = new ObservableCollection<PredictMethods>(source);
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
