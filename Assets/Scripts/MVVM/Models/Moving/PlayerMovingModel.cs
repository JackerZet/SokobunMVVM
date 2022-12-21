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
            //direction = Input.InputDirection.GetDirection();

            if (!Physics2D.OverlapPoint((Vector2)Movable.position + direction))
                Direction = direction;
        }
    }
}