using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Bordushko.TrainsSchedule.Models;

namespace Bordushko.TrainsSchedule.Views
{
    /// <summary>
    /// Interaction logic for TrainsScheduleDGrid.xaml
    /// </summary>
    public partial class TrainsScheduleDGrid : UserControl
    {
        public TrainsScheduleDGridController Controller { get; private set; }

        public TrainsScheduleDGrid()
        {
            InitializeComponent();
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                Controller = new TrainsScheduleDGridController(
                        this, DataSource);
                DataContext = Controller.CollectionView;
                //(PagedCollectionView)CollectionViewSource.GetDefaultView(DataSource); 
            }
        }

        public TrainInfoCollection DataSource
        {
            get
            {
                var app = Application.Current as App;
                if (app != null) return app.TrainInfoCollection;
                else return null;
            }
        }

        private void FirstPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.CollectionView.MoveToFirstPage();
        }

        private void FirstPage_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void LastPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.CollectionView.MoveToLastPage();
        }

        private void NextPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.CollectionView.MoveToNextPage();
        }

        private void PreviousPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.CollectionView.MoveToPreviousPage();
        }

        private void GoToPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.GoToPage((e.OriginalSource as TextBox).Text);
        }

        public void Filter(Func<object, bool> filterFunc)
        {
            Controller.Filter(filterFunc);
        }

        public void FilterReset()
        {
            Controller.FilterReset();
        }

        private void CurrentPageTextBoxInputValidation(object sender, TextCompositionEventArgs e)
        {
            Regex numsRegex = new Regex("[^0-9]+");
            e.Handled = numsRegex.IsMatch(e.Text);
        }
    }
}