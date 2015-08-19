using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Bordushko.TrainsSchedule.Models
{
    [Serializable]
    public class TrainInfoCollection : ObservableCollection<TrainInfo>
    {
        #region Constructors

        public TrainInfoCollection()
            :base()
        {
        }

        public TrainInfoCollection(IEnumerable<TrainInfo> trainsInfo)
            : base(trainsInfo)
        {
        }

        public TrainInfoCollection(List<TrainInfo> trainsInfo)
            : base(trainsInfo)
        {
        }

        #endregion Constructors

        #region Methods

        public static TrainInfoCollection Load(string filePath)
        {
            if (filePath != String.Empty)
            {
                XmlSerializer serializer = new XmlSerializer(
                    typeof(ObservableCollection<TrainInfo>));
                using (FileStream fStream = new FileStream(
                    filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    XmlReader reader = XmlReader.Create(fStream);
                    return new TrainInfoCollection(
                        (ObservableCollection<TrainInfo>)serializer.Deserialize(reader));
                } 
            }
            return null;
        }

        public void Save(string filePath)
        {
            if (filePath != String.Empty)
            {
                using (Stream fStream = new FileStream(
                    filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer xmlFormat = new XmlSerializer(
                        typeof(ObservableCollection<TrainInfo>));
                    xmlFormat.Serialize(fStream, this);
                } 
            }
            else
            {
                throw new ArgumentNullException("filePath");
            }
        }

        #endregion Methods
    }
}