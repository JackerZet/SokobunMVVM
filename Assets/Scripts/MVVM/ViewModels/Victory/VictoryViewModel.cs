using Sokobun.Models;
using System;

namespace Sokobun.ViewModels
{
    public class VictoryViewModel : IVictoryViewModel
    {
        public IVictoryModel VictoryModel { get; }
        public event Action OnPressEventHandler;
        public event Action OnReleaseEventHandler;
        public VictoryViewModel(IVictoryModel victoryModel)
        {
            VictoryModel = victoryModel;          
        }
        public void IsPressed()
        {
            if (VictoryModel.IsPressed)
                OnPressEventHandler?.Invoke();
            else
                OnReleaseEventHandler?.Invoke();
        }

        public void Dispose()
        {
            OnPressEventHandler = null;
            OnReleaseEventHandler = null;
        }
    }
}
