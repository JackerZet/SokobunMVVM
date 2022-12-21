using Sokobun.ViewModels;

namespace Sokobun.Views
{
    public interface IView
    {
        IMovingViewModel MovingViewModel { get; }
        void Init(IMovingViewModel movingViewModel);
    }
}