using Sokobun.Inputs;
using Sokobun.Models;
using Sokobun.Victory;
using Sokobun.ViewModels;
using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Infrastructure
{
    public class VictoryTileCreator : ICreator<VictoryTileView>
    {
        private VictoryCaretaker _victoryCaretaker;
        public VictoryTileCreator(VictoryCaretaker victory)
        {
            _victoryCaretaker = victory;
        }       
        public VictoryTileView FacroryMethod()
        {
            VictoryTileView view = Object.Instantiate(InputResources.Load<VictoryTileView>(nameof(VictoryTileView)));

            var model = new VictoryTileModel(view.transform);
            var viewModel = new VictoryViewModel(model);
            view.Init(viewModel, _victoryCaretaker);

            return view;           
        }
    }
}
