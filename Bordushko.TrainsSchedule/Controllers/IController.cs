using System.Windows.Data;
using Bordushko.TrainsSchedule.Views;

namespace Bordushko.TrainsSchedule.Controllers
{
    public interface IController
    {
        IView View { get; }
        PagedCollectionView CollectionView { get; set; }
    }
}