using Sokobun.Models;
using UnityEngine;

namespace Sokobun.ViewModels
{
    public interface IMovingViewModel
    {
        IMovingModel MovingModel { get; }
        Vector2 Direction { get; set; }
        void Move();      
    }
}
