using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Bordushko.TrainsSchedule.Models;

namespace Bordushko.TrainsSchedule
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public TrainInfoCollection TrainInfoCollection { get; set; }

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            try
            {
                TrainInfoCollection = new TrainInfoCollection();
                //{
                //    new TrainInfo("2345", "Минск", "Вильнюс",
                //        new DateTime(2015, 8, 31, 7, 40, 0),
                //        new DateTime(2015, 8, 31, 11, 0, 0)),
                //    new TrainInfo("6743", "Минск", "Берлин",
                //        new DateTime(2015, 8, 31, 9, 30, 0),
                //        new DateTime(2015, 8, 31, 23, 0, 0)),
                //    new TrainInfo("9074", "Минск", "Вильнюс",
                //        new DateTime(2015, 8, 31, 7, 40, 0),
                //        new DateTime(2015, 8, 31, 11, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0)),
                //    new TrainInfo("5831", "Прага", "Варшава",
                //        new DateTime(2015, 9, 1, 8, 40, 0),
                //        new DateTime(2015, 9, 1, 12, 0, 0))
                //};
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
            }
        }
    }
}
