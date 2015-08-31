using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Bordushko.TrainsSchedule.Models
{
    [Serializable, XmlRoot(Namespace = "http://www.bordushko.net/2015/trains-schedule")]
    public class TrainInfo : INotifyPropertyChanged
    {
        #region Private Fields
        private string number;
        private string departureStation;
        private string arrivalStation;
        private DateTime departureTime;
        private DateTime arrivalTime; 
        #endregion Private Fields

        #region Constructors

        public TrainInfo() 
        { }

        public TrainInfo(string number,
            string departureStation,
            string arrivalStation,
            DateTime departureTime,
            DateTime arrivalTime)
        {
            Number = number;
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
        }

        #endregion Constructors

        #region Properties

        [XmlAttribute]
        public string Number
        {
            get { return number; }
            set
            {
                if (number == value)
                    return;
                number = value;
                OnPropertyChanged("Number");
            }
        }

        [XmlAttribute]
        public string DepartureStation
        {
            get { return departureStation; }
            set
            {
                if (departureStation == value)
                    return;
                departureStation = value;
                OnPropertyChanged("DeapartureStation");
            }
        }

        [XmlAttribute]
        public string ArrivalStation
        {
            get { return arrivalStation; }
            set
            {
                if (arrivalStation == value) return;
                arrivalStation = value;
                OnPropertyChanged("ArrivalStation");
            }
        }

        [XmlAttribute]
        public DateTime DepartureTime
        {
            get { return departureTime; }
            set
            {
                if (departureTime == value) return;
                departureTime = value;
                OnPropertyChanged("DepartureTime");
            }
        }

        [XmlAttribute]
        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
            set
            {
                if (arrivalTime == value) return;
                arrivalTime = value;
                OnPropertyChanged("ArrivalTime");
            }
        }

        [XmlAttribute]
        public TimeSpan TravelTime
        {
            get { return ArrivalTime - DepartureTime; }
        }

        #endregion Properties

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
