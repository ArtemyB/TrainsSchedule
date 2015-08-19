using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Bordushko.TrainsSchedule.Models
{
    [Serializable, XmlRoot(Namespace = "http://www.bordushko.net/2015/trains-schedule")]
    public class TrainInfo : INotifyPropertyChanged
    {
        #region Constructors

        public TrainInfo() 
        { }

        public TrainInfo(string number,
            string departureStation,
            string arrivalStation,
            DateTime departureTime,
            DateTime arrivalTime,
            TimeSpan travelTime)
        {
            Number = number;
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            TravelTime = travelTime;
        }

        #endregion Constructors

        #region Properties

        [XmlAttribute]
        public string Number { get; set; }

        [XmlAttribute]
        public string DepartureStation { get; set; }

        [XmlAttribute]
        public string ArrivalStation { get; set; }

        [XmlAttribute]
        public DateTime DepartureTime { get; set; }

        [XmlAttribute]
        public DateTime ArrivalTime { get; set; }

        [XmlAttribute]
        public TimeSpan TravelTime { get; set; }

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
