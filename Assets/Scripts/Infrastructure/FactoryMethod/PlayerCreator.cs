using Sokobun.Data;
using Sokobun.Inputs;
using Sokobun.Models;
using Sokobun.ViewModels;
using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Infrastructure
{
    public class PlayerCreator : ICreator<PlayerView> 
    {
        public PlayerView FacroryMethod()
        {
            PlayerView view = Object.Instantiate(InputResources.Load<PlayerView>(nameof(PlayerView)));

            var model = new PlayerMovingModel(view.transform);
            var viewModel = new MovingViewModel(model);
            view.Init(viewModel);

            return view;
        }
    }
}
