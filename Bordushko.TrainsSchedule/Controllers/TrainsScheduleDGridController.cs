using System;
using System.Security.Policy;
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
            cView = new PagedCollectionView(collection);
        }

        public int PagesCount
        {
            get { return cView.Count / cView.PageSize; }
        }

        public void MoveToFirstPage()
        {
            cView.MoveToFirstPage();
        }

        public void MoveToLasPage()
        {
            cView.MoveToLastPage();
        }

        public void MoveToPreviousPage()
        {
            cView.MoveToPreviousPage();
        }

        public void MoveToNextPage()
        {
            cView.MoveToNextPage();
        }

        public void MoveToPage(int pageNumber)
        {
            cView.MoveToPage(pageNumber);
        }
    }
}