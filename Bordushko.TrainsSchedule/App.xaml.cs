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
