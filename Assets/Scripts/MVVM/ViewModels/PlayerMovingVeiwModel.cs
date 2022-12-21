using Sokobun.Models;
using UnityEngine;

namespace Sokobun.ViewModels
{
    public class PlayerMovingVeiwModel : IMovingViewModel
    {
        public IMovingModel MovingModel { get; }
        public Vector2 Direction 
        { 
            get => MovingModel.Direction;
            set => MovingModel.SetDirection(value);            
        }

        public PlayerMovingVeiwModel(IMovingModel movingModel)
        {
            MovingModel = movingModel;
        }

        public void Move()
        {
            MovingModel.Move();
        }
    }
}
