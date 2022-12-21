using Sokobun.ViewModels; 
using UnityEngine;

namespace Sokobun.Views
{
    public class PushableView : MonoBehaviour, IView
    {
        public IMovingViewModel MovingViewModel { get; private set; }
        public void Init(IMovingViewModel movingViewModel)
        {
            MovingViewModel = movingViewModel;
        }
    }
}
