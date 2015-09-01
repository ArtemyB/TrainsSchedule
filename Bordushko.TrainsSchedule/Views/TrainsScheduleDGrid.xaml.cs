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
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                Controller = new TrainsScheduleDGridController(
                            this, DataSource);

                InitializeComponent();
            
                DataContext = Controller.CollectionView;
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

        #region Methods
        public void Filter(Func<object, bool> filterFunc)
        {
            Controller.Filter(filterFunc);
        }

        public void FilterReset()
        {
            Controller.FilterReset();
        }
        #endregion Methods

        #region Commands' Handlers

        private void FirstPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.CollectionView.MoveToFirstPage();
        }
        private void FirstPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Controller.CanGoToFirstAndPrevPage;
        }

        private void LastPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.CollectionView.MoveToLastPage();
        }
        private void LastPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Controller.CanGoToLastAndNextPage;
        }

        private void NextPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.CollectionView.MoveToNextPage();
        }
        private void NextPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Controller.CanGoToLastAndNextPage;
        }

        private void PreviousPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.CollectionView.MoveToPreviousPage();
        }
        private void PreviousPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Controller.CanGoToFirstAndPrevPage;
        }

        private void GoToPage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Controller.GoToPage((e.OriginalSource as TextBox).Text);
        }

        private void CurrentPageTextBoxInputValidation(object sender, TextCompositionEventArgs e)
        {
            Regex numsRegex = new Regex("[^0-9]+");
            e.Handled = numsRegex.IsMatch(e.Text);
        }

        private void GoToPage_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Controller.CanGoToPage;
        }
 
        #endregion Commands' Handlers
    }
}