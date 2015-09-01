using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Bordushko.TrainsSchedule.Controllers;
using Bordushko.TrainsSchedule.Views;
using Microsoft.Win32;

namespace Bordushko.TrainsSchedule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowController Controller { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            Controller = new MainWindowController(this);
            DataContext = (Application.Current as App).TrainInfoCollection;
        }

        private void AddRecordButton_Click(object sender, RoutedEventArgs e)
        {
            AddRecordDialog dialog = new AddRecordDialog();
            dialog.ShowDialog();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchDialog dialog = new SearchDialog();
            dialog.ShowDialog();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            RemoveDialog dialog = new RemoveDialog();
            dialog.ShowDialog();
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Trains Schedule (.schd)|*.schd|XML file (.xml)|*.xml",
                DefaultExt = "schd",
                ValidateNames = true
            };
            dialog.ShowDialog();
            (Application.Current as App).TrainInfoCollection.Save(dialog.FileName);
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void MainWindow_OnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = !Controller.CanCloseApp;
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.LoadFile();
        }
    }
}
