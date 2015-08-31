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
using Bordushko.TrainsSchedule.Utils;

namespace Bordushko.TrainsSchedule.Views
{
    /// <summary>
    /// Interaction logic for SearchComponent.xaml
    /// </summary>
    public partial class SearchForm : UserControl, IView
    {
        //private readonly SearchComponentController controller;
        public IController Controller { get; private set; }

        public SearchForm()
        {
            InitializeComponent();
            Controller = new SearchFormController(this);
        }

        //public int TrainNumber
        //{
        //    get { return (int)GetValue(TrainNumberProperty); }
        //    set { SetValue(TrainNumberProperty, value); }
        //}

        //public static readonly DependencyProperty TrainNumberProperty =
        //    DependencyProperty.Register("TrainNumber", typeof(int), typeof(SearchForm), new PropertyMetadata(0));

        //public string DepStation
        //{
        //    get { return (string)GetValue(DepStationProperty); }
        //    set { SetValue(DepStationProperty, value); }
        //}

        //public static readonly DependencyProperty DepStationProperty =
        //    DependencyProperty.Register("DepStation", typeof(string), typeof(SearchForm), new PropertyMetadata(""));

        //public string ArrStation
        //{
        //    get { return (string)GetValue(ArrStationProperty); }
        //    set { SetValue(ArrStationProperty, value); }
        //}

        //public static readonly DependencyProperty ArrStationProperty =
        //    DependencyProperty.Register("ArrStation", typeof(string), typeof(SearchForm), new PropertyMetadata(""));

        //public DateTime DepTimeMin
        //{
        //    get { return (DateTime)GetValue(DepTimeMinProperty); }
        //    set { SetValue(DepTimeMinProperty, value); }
        //}

        //public static readonly DependencyProperty DepTimeMinProperty =
        //    DependencyProperty.Register("DepTimeMin", typeof(DateTime), typeof(SearchForm), new PropertyMetadata(null));

        //public DateTime DepTimeMax
        //{
        //    get { return (DateTime)GetValue(DepTimeMaxProperty); }
        //    set { SetValue(DepTimeMaxProperty, value); }
        //}

        //public static readonly DependencyProperty DepTimeMaxProperty =
        //    DependencyProperty.Register("DepTimeMax", typeof(DateTime), typeof(SearchForm), new PropertyMetadata(null));

        //public DateTime ArrTimeMin
        //{
        //    get { return (DateTime)GetValue(ArrTimeMinProperty); }
        //    set { SetValue(ArrTimeMinProperty, value); }
        //}

        //public static readonly DependencyProperty ArrTimeMinProperty =
        //    DependencyProperty.Register("ArrTimeMin", typeof(DateTime), typeof(SearchForm), new PropertyMetadata(null));

        //public DateTime ArrTimeMax
        //{
        //    get { return (DateTime)GetValue(ArrTimeMaxProperty); }
        //    set { SetValue(ArrTimeMaxProperty, value); }
        //}

        //public static readonly DependencyProperty ArrTimeMaxProperty =
        //    DependencyProperty.Register("ArrTimeMax", typeof(DateTime), typeof(SearchForm), new PropertyMetadata(null));
        
        //public TimeSpan TravelTime
        //{
        //    get { return (TimeSpan)GetValue(TravelTimeProperty); }
        //    set { SetValue(TravelTimeProperty, value); }
        //}

        //public static readonly DependencyProperty TravelTimeProperty =
        //    DependencyProperty.Register("TravelTime", typeof(TimeSpan), typeof(SearchForm), new PropertyMetadata(null));
    }
}