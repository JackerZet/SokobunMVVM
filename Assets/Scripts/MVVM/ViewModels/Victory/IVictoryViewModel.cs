using Sokobun.Models;
using System;

namespace Sokobun.ViewModels
{
    public interface IVictoryViewModel : IDisposable
    {
        IVictoryModel VictoryModel { get; }
        event Action OnPressEventHandler;
        event Action OnReleaseEventHandler;
        public void IsPressed();
    }
}
