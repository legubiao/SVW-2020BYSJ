using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using BYSJ.Models;

namespace BYSJ.ViewModels
{
    public class PredictionViewModel : INotifyPropertyChanged
    {
        readonly IList<PredictMethods> source;
        public ObservableCollection<PredictMethods> Methods { get; private set; }

        public PredictionViewModel()
        {
            source = new List<PredictMethods>();
            CreateMethods();
        }

        void CreateMethods()
        {
            source.Add(new PredictMethods
            {
                Name = "移动平滑",
                Details = "一种比较简单的预测方法，仅考虑前n项数据",
                ImageUrl = ""

            });

            source.Add(new PredictMethods
            {
                Name = "指数平滑",
                Details = "一种比较简单的预测方法，考虑到了所有的历史数据",
                ImageUrl = ""
            });

            source.Add(new PredictMethods
            {
                Name = "CNN",
                Details = "由安同学开发的预测算法",
                ImageUrl = ""
            });

            source.Add(new PredictMethods
            {
                Name = "KNN",
                Details = "周同学负责的预测算法",
                ImageUrl = ""
            });

            Methods = new ObservableCollection<PredictMethods>(source);
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
