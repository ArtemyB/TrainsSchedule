using System;
using System.Net.Mime;
using System.Windows;
using System.Windows.Data;
using Bordushko.TrainsSchedule.Models;

namespace Bordushko.TrainsSchedule.Controllers
{
    public class MainWindowController
    {
        private readonly PagedCollectionView trainsInfoView;
        private readonly MainWindow trainsInfoWindow;

        public MainWindowController(MainWindow window, TrainInfoCollection trainsInfo)
        {
            if (window == null)
                throw new ArgumentNullException("window");

            if (trainsInfo == null)
                throw new ArgumentNullException("trainsInfo");

            trainsInfoWindow = window;
            trainsInfoView = new PagedCollectionView(trainsInfo);
        }
    }
}