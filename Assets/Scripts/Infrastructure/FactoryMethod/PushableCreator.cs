using Sokobun.Inputs;
using Sokobun.Models;
using Sokobun.ViewModels;
using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Infrastructure
{
    public class PushableCreator : ICreator<PushableView>
    {
        public PushableView FacroryMethod()
        {
            PushableView view = Object.Instantiate(InputResources.Load<PushableView>(nameof(PushableView)));
            
            var model = new PushableMovingModel(view.transform);
            var viewModel = new MovingViewModel(model);
            view.Init(viewModel);

            return view;
        }
    }
}
