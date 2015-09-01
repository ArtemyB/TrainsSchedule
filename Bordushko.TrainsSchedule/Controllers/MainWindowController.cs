using System;
using System.Net.Mime;
using System.Windows;
using System.Windows.Data;
using Bordushko.TrainsSchedule.Models;
using Microsoft.Win32;
using MessageBox = System.Windows.MessageBox;

namespace Bordushko.TrainsSchedule.Controllers
{
    public class MainWindowController
    {
        private string fileFilter = "Trains Schedule (.schd)|*.schd|XML file (.xml)|*.xml";

        private TrainInfoCollection dataSource =
            (Application.Current as App).TrainInfoCollection;

        public MainWindow View { get; private set; }

        public bool CanCloseApp
        {
            get
            {
                MessageBoxResult result =
                    MessageBox.Show(
                    "Хотите выйти, даже если после этого вы потеряете несохранённые результаты?",
                    "Выход из приложения", MessageBoxButton.YesNo);
                return result == MessageBoxResult.Yes ? true : false;
            }
        }

        public MainWindowController(MainWindow view)
        {
            if (view == null)
                throw new ArgumentNullException("view");

            View = view;
        }

        public void LoadFile()
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = fileFilter,
                AddExtension = true,
                CheckPathExists = true,
                DefaultExt = "schd"
            };
            dialog.ShowDialog();
            dataSource.Clear();
            foreach (var item in TrainInfoCollection.Load(dialog.FileName))
            {
                dataSource.Add(item);
            }
            
        }
    }
}