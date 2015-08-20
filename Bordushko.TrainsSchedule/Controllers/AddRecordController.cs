using System;
using System.Windows;
using Bordushko.TrainsSchedule.Models;
using Bordushko.TrainsSchedule.Views;

namespace Bordushko.TrainsSchedule.Controllers
{
    public class AddRecordController
    {
        private readonly AddRecordDialog view;

        public AddRecordController(AddRecordDialog view)
        {
            if (view == null)
                throw new ArgumentNullException("view");

            this.view = view;
        }

        public void AddRecord(TrainInfo record)
        {
            if (record != null)
            {
                (Application.Current as App).TrainInfoCollection.Add(record);
            }
            else
            {
                throw new ArgumentNullException("record"); 
            }
        }
    }
}