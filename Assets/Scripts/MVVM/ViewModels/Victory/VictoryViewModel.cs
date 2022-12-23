using Sokobun.Models;
using System;

namespace Sokobun.ViewModels
{
    public class VictoryViewModel : IVictoryViewModel
    {
        public IVictoryModel VictoryModel { get; }
        public event Action OnPressEventHandler;
        public event Action OnReleaseEventHandler;

        private bool _alreadyPressed = false;
        public VictoryViewModel(IVictoryModel victoryModel)
        {
            VictoryModel = victoryModel;          
        }
        public void IsPressed()
        {
            bool overlap = VictoryModel.IsPressed;

            if (!_alreadyPressed && overlap)
            {
                _alreadyPressed = true;
                OnPressEventHandler?.Invoke();
            }

            else if (_alreadyPressed && !overlap)
            {
                _alreadyPressed = false;
                OnReleaseEventHandler?.Invoke();
            }
        }

        public void Dispose()
        {
            OnPressEventHandler = null;
            OnReleaseEventHandler = null;
        }
    }
}
