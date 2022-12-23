using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Models
{
    public class VictoryTileModel : IVictoryModel
    {
        public Transform Point { get; }
        public bool IsPressed => Physics2D.OverlapPoint(Point.position).gameObject.TryGetComponent(out PushableView _);

        public VictoryTileModel(Transform transform)
        {
            Point = transform;
        }
    }
}
