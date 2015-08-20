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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bordushko.TrainsSchedule.Controllers;

namespace Bordushko.TrainsSchedule.Views
{
    /// <summary>
    /// Interaction logic for TrainsScheduleDGrid.xaml
    /// </summary>
    public partial class TrainsScheduleDGrid : UserControl
    {
        private readonly TrainsScheduleDGridController controller;

        public TrainsScheduleDGrid()
        {
            InitializeComponent();
            controller = new TrainsScheduleDGridController(
                this, (Application.Current as App).TrainInfoCollection);
            CollectionViewSource cvs = new CollectionViewSource();
            DataContext = (Application.Current as App).TrainInfoCollection;
        }

        private void FirstPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            controller.MoveToFirstPage();
        }

        private void FirstPage_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void LastPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            controller.MoveToLasPage();
        }

        private void NextPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            controller.MoveToNextPage();
        }

        private void PreviousPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            controller.MoveToPreviousPage();
        }

        private void GoToPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            controller.MoveToPage(0);
        }
    }
}
