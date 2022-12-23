using Sokobun.Victory;
using Sokobun.ViewModels;
using UnityEngine;

namespace Sokobun.Views
{
    public class VictoryTileView : MonoBehaviour
    {
        public IVictoryViewModel VictoryViewModel { get; private set; }
        public void Init(IVictoryViewModel victoryViewModel, VictoryCaretaker victoryCaretaker)
        {
            VictoryViewModel = victoryViewModel;
            
            victoryViewModel.OnPressEventHandler += victoryCaretaker.OnPressTile;
            victoryViewModel.OnReleaseEventHandler += victoryCaretaker.OnReleaseTile;
        }
        ~VictoryTileView()
        {
            VictoryViewModel.Dispose();
        }
    }
}
