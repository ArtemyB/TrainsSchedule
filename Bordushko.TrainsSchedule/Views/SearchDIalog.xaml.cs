using System;
using System.Collections.Generic;
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
using Bordushko.TrainsSchedule.Utils;

namespace Bordushko.TrainsSchedule.Views
{
    /// <summary>
    /// Interaction logic for SearchDIalog.xaml
    /// </summary>
    public partial class SearchDialog : Window
    {
        public SearchDialogController Controller { get; private set; }

        public SearchFormModel SearchingProps { get; private set; }

        public SearchDialog()
        {
            InitializeComponent();
            Controller = new SearchDialogController(this);
            SearchFormModel model = new SearchFormModel();
            SearchingProps = model;
            DataContext = model;
        }

        private void SearchByTrNumberAndDepTime_Click(object sender, RoutedEventArgs e)
        {
            Controller.FilterByNumberAndDepTime();
        }

        private void SearchByDepAndArrTime_Click(object sender, RoutedEventArgs e)
        {
            Controller.FIlterByDepAndArrTime();
        }

        private void SearchByDepOrArrStation_Click(object sender, RoutedEventArgs e)
        {
            Controller.FilterByDepOrArrStation();
        }

        private void SearchByTravelTime_Click(object sender, RoutedEventArgs e)
        {
            Controller.FilterByTravelTime();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ScheduleDGrid.FilterReset();
        }
    }
}