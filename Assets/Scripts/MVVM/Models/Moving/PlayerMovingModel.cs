using Sokobun.Inputs;
using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Models
{
    public class PlayerMovingModel : IMovingModel
    {
        public Transform Movable { get; }
        public Vector2 Direction { get; set; }
        public PlayerMovingModel(Transform movable)
        {
            Movable = movable;
            Direction = Vector2.zero;
        }       
        public void Move()
        {
            if (Direction == Vector2.zero) return;

            Movable.Translate(Direction);
        }
        public void SetDirection(Vector2 direction)
        {
            var hit = Physics2D.OverlapPoint((Vector2)Movable.position + direction, ~InputLayers.TileLayerMask);

            if (!hit)
            {
                Direction = direction;
            }
            else if(hit.gameObject.TryGetComponent(out PushableView view))
            {
                view.MovingViewModel.Direction = direction;
                Direction = view.MovingViewModel.Direction;
            }
            else
            {
                Direction = Vector2.zero;
            }
        }
    }
}