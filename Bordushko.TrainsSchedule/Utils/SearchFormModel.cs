using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Bordushko.TrainsSchedule.Annotations;
using Bordushko.TrainsSchedule.Views;

namespace Bordushko.TrainsSchedule.Utils
{
    public class SearchFormModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Implementation
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private string trainNumber;
        private string depStation;
        private string arrStation;
        private DateTime depTimeMin;
        private DateTime depTimeMax;
        private DateTime arrTimeMin;
        private DateTime arrTimeMax;
        private TimeSpan travelTime;
        public event PropertyChangedEventHandler PropertyChanged;

        public string TrainNumber
        {
            get { return trainNumber; }
            set
            {
                if (value == trainNumber) return;
                trainNumber = value;
                OnPropertyChanged();
            }
        }

        public string DepStation
        {
            get { return depStation; }
            set
            {
                if (value == depStation) return;
                depStation = value;
                OnPropertyChanged();
            }
        }

        public string ArrStation
        {
            get { return arrStation; }
            set
            {
                if (value == arrStation) return;
                arrStation = value;
                OnPropertyChanged();
            }
        }

        public DateTime DepTimeMin
        {
            get { return depTimeMin; }
            set
            {
                if (value.Equals(depTimeMin)) return;
                depTimeMin = value;
                OnPropertyChanged();
            }
        }

        public DateTime DepTimeMax
        {
            get { return depTimeMax; }
            set
            {
                if (value.Equals(depTimeMax)) return;
                depTimeMax = value;
                OnPropertyChanged();
            }
        }

        public DateTime ArrTimeMin
        {
            get { return arrTimeMin; }
            set
            {
                if (value.Equals(arrTimeMin)) return;
                arrTimeMin = value;
                OnPropertyChanged();
            }
        }

        public DateTime ArrTimeMax
        {
            get { return arrTimeMax; }
            set
            {
                if (value.Equals(arrTimeMax)) return;
                arrTimeMax = value;
                OnPropertyChanged();
            }
        }

        public TimeSpan TravelTime
        {
            get { return travelTime; }
            set
            {
                if (value.Equals(travelTime)) return;
                travelTime = value;
                OnPropertyChanged();
            }
        }
    }
}