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
using Bordushko.TrainsSchedule.Models;
using Bordushko.TrainsSchedule.Controllers;

namespace Bordushko.TrainsSchedule.Views
{
    /// <summary>
    /// Interaction logic for SearchComponent.xaml
    /// </summary>
    public partial class SearchComponent : UserControl
    {
        private readonly SearchComponentController controller;
        private PagedCollectionView collectionView;
        private IEnumerable<TrainInfo> searchResult;
        public TrainSearchOptions SearchOption { get; set; }

        public SearchComponent()
        {
            InitializeComponent();
        }

        private void SearchByTrNumberAndDepTime_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void SearchByDepAndArrTime_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
