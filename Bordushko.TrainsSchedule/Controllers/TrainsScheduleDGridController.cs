using System;
using System.ComponentModel;
using System.Security.Policy;
using System.Windows;
using System.Windows.Data;
using Bordushko.TrainsSchedule.Models;
using Bordushko.TrainsSchedule.Views;

namespace Bordushko.TrainsSchedule.Controllers
{
    public class TrainsScheduleDGridController
    {
        private readonly TrainsScheduleDGrid view;
        private readonly PagedCollectionView cView;

        public TrainsScheduleDGridController(TrainsScheduleDGrid view,
            TrainInfoCollection collection)
        {
            if (view == null)
                throw new ArgumentNullException("view");
            if (collection == null)
                throw new ArgumentNullException("collection");

            this.view = view;
            cView = new PagedCollectionView(collection) {PageSize = 10};
        }

        public PagedCollectionView CollectionView
        {
            get { return cView; }
        }

        public int PagesCount
        {
            get { return CollectionView.TotalItemCount / CollectionView.PageSize; }
        }

        public bool CanGoToLastAndNextPage
        {
            get { return CollectionView.PageIndex < PagesCount ? true : false; }
        }

        public bool CanGoToFirstAndPrevPage
        {
            get { return CollectionView.PageIndex > 0 ? true : false; }
        }

        public bool CanGoToPage
        {
            get { return PagesCount > 1 ? true : false; }
        }

        public void GoToPage(string indexStr)
        {
            int index = int.Parse(indexStr);
            if (index >= 0 && index <= PagesCount)
                CollectionView.MoveToPage(index); 
        }

        public void Filter(Func<object, bool> filterFunc)
        {
            cView.Filter = new Predicate<object>(filterFunc);
        }

        public void FilterReset()
        {
            cView.Filter = null;
        }
    }
}

//public int PagesCount
//{
//    get { return cView.Count / cView.PageSize; }
//}

//public void MoveToFirstPage()
//{
//    cView.MoveToFirstPage();
//}

//public void MoveToLasPage()
//{
//    cView.MoveToLastPage();
//}

//public void MoveToPreviousPage()
//{
//    cView.MoveToPreviousPage();
//}

//public void MoveToNextPage()
//{
//    cView.MoveToNextPage();
//}

//public void MoveToPage(int pageNumber)
//{
//    cView.MoveToPage(pageNumber);
//}