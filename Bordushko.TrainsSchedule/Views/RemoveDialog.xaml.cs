using System.Windows;
using Bordushko.TrainsSchedule.Controllers;
using Bordushko.TrainsSchedule.Utils;

namespace Bordushko.TrainsSchedule.Views
{
    /// <summary>
    /// Interaction logic for RemoveWindow.xaml
    /// </summary>
    public partial class RemoveDialog : Window
    {
        public RemoveDialogController Controller { get; private set; }

        public SearchFormModel SearchProps { get; private set; }

        public RemoveDialog()
        {
            InitializeComponent();
            Controller = new RemoveDialogController(this);
            SearchProps = new SearchFormModel();
            DataContext = SearchProps;
        }

        private void RemoveByTrNumberAndDepTime_Click(object sender, RoutedEventArgs e)
        {
            Controller.RemoveByNumberAndDepTime();
        }

        private void RemoveByDepAndArrTime_Click(object sender, RoutedEventArgs e)
        {
            Controller.RemoveByDepAndArrTime();
        }

        private void RemoveByDepOrArrStation_Click(object sender, RoutedEventArgs e)
        {
            Controller.RemoveByDepOrArrStation();
        }

        private void RemoveByTravelTime_Click(object sender, RoutedEventArgs e)
        {
            Controller.RemoveByTravelTime();
        }
    }
}
