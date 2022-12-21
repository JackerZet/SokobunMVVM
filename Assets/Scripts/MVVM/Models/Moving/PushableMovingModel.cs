using UnityEngine;

namespace Sokobun.Models
{
    public class PushableMovingModel : IMovingModel
    {
        public Transform Movable { get; }
        public Vector2 Direction { get; set; }
        public PushableMovingModel(Transform movable)
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
            Direction = direction;
        }
    }
}