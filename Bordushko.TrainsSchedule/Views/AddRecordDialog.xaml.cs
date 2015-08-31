using System;
using System.Windows;
using System.Windows.Input;
using Bordushko.TrainsSchedule.Controllers;
using Bordushko.TrainsSchedule.Models;
using Bordushko.TrainsSchedule.Utils;

namespace Bordushko.TrainsSchedule.Views
{
    /// <summary>
    /// Interaction logic for AddRecordDialog.xaml
    /// </summary>
    public partial class AddRecordDialog : Window
    {
        private readonly AddRecordController controller;

        public AddRecordDialog()
        {
            InitializeComponent();
            controller = new AddRecordController(this);
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void NewRecord_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            controller.AddRecord(
                new TrainInfo(NumberField.Text,
                DepStationField.Text,
                ArrStationField.Text,
                DateTime.Parse(DepTimeField.Text),
                DateTime.Parse(ArrTimeField.Text)));
            Close();
        }

        private void NewRecord_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (CheckUp.IsAnyStringEmpty(NumberField.Text, DepStationField.Text,
                                        ArrStationField.Text, DepTimeField.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true; 
            }
        }
    }
}
