using System;
using System.Linq;
using System.Windows;
using Bordushko.TrainsSchedule.Models;
using Bordushko.TrainsSchedule.Utils;
using Bordushko.TrainsSchedule.Views;

namespace Bordushko.TrainsSchedule.Controllers
{
    public class RemoveDialogController
    {
        public RemoveDialog View { get; private set; }

        public TrainInfoCollection DataSource
        {
            get { return (Application.Current as App).TrainInfoCollection; }
        }

        public RemoveDialogController(RemoveDialog view)
        {
            if (view == null) throw new ArgumentNullException("view");

            View = view;
        }

        public void RemoveByNumberAndDepTime()
        {
            int recordsCount = 0;
            foreach (TrainInfo trainInfo in DataSource.ToList().Where(trainInfo =>
                trainInfo.Number == View.SearchProps.TrainNumber &&
                trainInfo.DepartureTime == View.SearchProps.DepTimeMin))
            {
                DataSource.Remove(trainInfo);
                recordsCount++;
            }
            RemovingNotification(recordsCount);
        }

        public void RemoveByDepAndArrTime()
        {
            int recordsCount = 0;
            foreach (TrainInfo trainInfo in DataSource.ToList().Where(trainInfo =>
                trainInfo.DepartureTime >= View.SearchProps.DepTimeMin &&
                trainInfo.DepartureTime <= View.SearchProps.DepTimeMax &&
                trainInfo.ArrivalTime >= View.SearchProps.ArrTimeMin &&
                trainInfo.ArrivalTime <= View.SearchProps.ArrTimeMax))
            {
                DataSource.Remove(trainInfo);
                recordsCount++;
            }
            RemovingNotification(recordsCount);
        }

        public void RemoveByDepOrArrStation()
        {
            int recordsCount = 0;
            foreach (TrainInfo trainInfo in DataSource.ToList().Where(trainInfo =>
                trainInfo.DepartureStation == View.SearchProps.DepStation ||
                trainInfo.ArrivalStation == View.SearchProps.ArrStation))
            {
                DataSource.Remove(trainInfo);
                recordsCount++;
            }
            RemovingNotification(recordsCount);
        }

        public void RemoveByTravelTime()
        {
            int recordsCount = 0;
            foreach (TrainInfo trainInfo in DataSource.ToList().Where(trainInfo =>
                trainInfo.TravelTime == View.SearchProps.TravelTime))
            {
                DataSource.Remove(trainInfo);
                recordsCount++;
            }
            RemovingNotification(recordsCount);
        }

        public void RemovingNotification(int itemsCount)
        {
            string caption = "Результат поиска и удаления";
            if (itemsCount == 0)
                MessageBox.Show("Информации о поездах, удовлетворяющей указанным условиям не найдено",
                    caption, MessageBoxButton.OK);
            else
            {
                string message = "Найдено и удалено " + itemsCount + " записей.";
                MessageBox.Show(message, caption, MessageBoxButton.OK);
            }
                
        }
    }
}