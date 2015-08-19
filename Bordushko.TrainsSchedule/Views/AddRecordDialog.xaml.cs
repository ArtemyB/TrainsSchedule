using System.Windows;
using System.Windows.Input;
using Bordushko.TrainsSchedule.Utils;

namespace Bordushko.TrainsSchedule.Views
{
    /// <summary>
    /// Interaction logic for AddRecordDialog.xaml
    /// </summary>
    public partial class AddRecordDialog : Window
    {

        public AddRecordDialog()
        {
            InitializeComponent();
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void createRecord_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NewRecord_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Close_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (CheckUp.IsAnyStringEmpty(NumberField.Text, DepStationField.Text,
                                        ArrStationField.Text, DepTimeField.Text,
                                        ArrTimeField.Text,TravelTimeField.Text))
            {
                e.CanExecute = false;
            }
            e.CanExecute = true;
        }
    }
}
