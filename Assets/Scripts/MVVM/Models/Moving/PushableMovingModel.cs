using Sokobun.Inputs;
using Sokobun.Views;
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
            var hit = Physics2D.OverlapPoint((Vector2)Movable.position + direction, ~InputLayers.TileLayerMask);
            var reverseHit = Physics2D.OverlapPoint((Vector2)Movable.position - direction, ~InputLayers.TileLayerMask);
                     
            if (reverseHit == null)
                Direction = Vector2.zero;

            else if (!hit && reverseHit.gameObject.TryGetComponent(out PlayerView _))
                Direction = direction;
            
            else
                Direction = Vector2.zero;        
            
        }
    }
}