using Sokobun.Models;
using UnityEngine;

namespace Sokobun.ViewModels
{
    public class PushableMovingViewModel : IMovingViewModel
    {
        public IMovingModel MovingModel { get; }
        public Vector2 Direction
        {
            get => MovingModel.Direction;
            set => MovingModel.SetDirection(value);
        }
        public PushableMovingViewModel(IMovingModel movingModel)
        {
            MovingModel = movingModel;
        }
        public void Move()
        {
            MovingModel.Move();
        }
    }
}
