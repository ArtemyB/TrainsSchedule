using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Bordushko.TrainsSchedule.Annotations;
using Bordushko.TrainsSchedule.Models;
using Bordushko.TrainsSchedule.Views;

namespace Bordushko.TrainsSchedule.Controllers
{
    internal class SearchFormController : IController
    {
        private readonly SearchForm view;
        public IView View { get; private set; }
        public PagedCollectionView CollectionView { get; set; }

        public SearchFormController(SearchForm view)
        {
            if (view == null)
                throw new ArgumentNullException("view");
            this.view = view;
        }

        //public bool FilterByNumberAndDepTime(Object info)
        //{
        //    if (info is TrainInfo)
        //    {
        //        TrainInfo current = info as TrainInfo;
        //        if (current.Number == view.TrNumberField.Text &&
        //            current.DepartureTime == DateTime.Parse(view.DepTime1Field.Text))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public bool FIlterByDepAndArrTime(Object info)
        //{
        //    if (info is TrainInfo)
        //    {
        //        TrainInfo current = info as TrainInfo;
        //        if (current.DepartureTime >= DateTime.Parse(view.DepTime1Field.Text) &&
        //            current.DepartureTime <= DateTime.Parse(view.DepTime2Field.Text) &&
        //            current.ArrivalTime >= DateTime.Parse(view.ArrTime1Field.Text) &&
        //            current.ArrivalTime <= DateTime.Parse(view.ArrTime2Field.Text))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public bool FilterByDepOrArrStation(Object info)
        //{
        //    if (info is TrainInfo)
        //    {
        //        TrainInfo current = info as TrainInfo;
        //        if (current.DepartureStation == view.DepStationField.Text ||
        //            current.ArrivalStation == view.ArrStationField.Text)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public bool FilterByTravelTime(Object info)
        //{
        //    if (info is TrainInfo)
        //    {
        //        TrainInfo current = info as TrainInfo;
        //        if (current.TravelTime == TimeSpan.Parse(view.TravelTimeField.Text))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}