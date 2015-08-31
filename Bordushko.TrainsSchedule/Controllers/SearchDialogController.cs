using System;
using System.Windows.Data;
using Bordushko.TrainsSchedule.Models;
using Bordushko.TrainsSchedule.Views;

namespace Bordushko.TrainsSchedule.Controllers
{
    public class SearchDialogController
    {
        public SearchDialog View { get; private set; }

        public SearchDialogController(SearchDialog view)
        {
            if (view == null) throw new ArgumentNullException("view");

            View = view;
        }

        public void FilterByNumberAndDepTime()
        {
            View.ScheduleDGrid.Filter(info => {
                if (info is TrainInfo)
                {
                    TrainInfo current = info as TrainInfo;
                    if (current.Number == View.SearchingProps.TrainNumber &&
                        current.DepartureTime == View.SearchingProps.DepTimeMin)
                    {
                        return true;
                    }
                }
                return false;
            });
        }

        public void FIlterByDepAndArrTime()
        {
            View.ScheduleDGrid.Filter(info => {
                if (info is TrainInfo)
                {
                    TrainInfo current = info as TrainInfo;
                    if (current.DepartureTime >= View.SearchingProps.DepTimeMin &&
                        current.DepartureTime <= View.SearchingProps.DepTimeMax&&
                        current.ArrivalTime >= View.SearchingProps.ArrTimeMin &&
                        current.ArrivalTime <= View.SearchingProps.ArrTimeMax)
                    {
                        return true;
                    }
                }
                return false;
            });
        }

        public void FilterByDepOrArrStation()
        {
            View.ScheduleDGrid.Filter(info => {
                if (info is TrainInfo)
                {
                    TrainInfo current = info as TrainInfo;
                    if (current.DepartureStation == View.SearchingProps.DepStation ||
                        current.ArrivalStation == View.SearchingProps.ArrStation)
                    {
                        return true;
                    }
                }
                return false;
            });
        }

        public void FilterByTravelTime()
        {
            View.ScheduleDGrid.Filter(info => {
                if (info is TrainInfo)
                {
                    TrainInfo current = info as TrainInfo;
                    if (current.TravelTime == View.SearchingProps.TravelTime)
                    {
                        return true;
                    }
                }
                return false;
            });
        }
    }
}