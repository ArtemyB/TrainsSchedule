using Bordushko.TrainsSchedule.Controllers;

namespace Bordushko.TrainsSchedule.Views
{
    public interface IView
    {
        IController Controller { get; }
    }
}