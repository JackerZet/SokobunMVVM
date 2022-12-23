using Sokobun.Inputs;
using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Infrastructure
{
    public class WallCretor : ICreator<WallView>
    {
        public WallView FacroryMethod()
        {
            return Object.Instantiate(InputResources.Load<WallView>(nameof(WallView)));
        }
    }
}
