using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Models
{
    public class VictoryTileModel : IVictoryModel
    {
        public Transform Point { get; }

        private bool _alreadyPressed;
        public bool IsPressed
        {
            get
            {
                bool overlap = Physics2D.OverlapPoint(Point.position).gameObject.TryGetComponent(out PushableView _);

                if (!_alreadyPressed && overlap)
                    _alreadyPressed = true;
                else if(_alreadyPressed && !overlap)
                    _alreadyPressed = false;
                
                return _alreadyPressed; 
            }
        }             
        public VictoryTileModel(Transform transform)
        {
            Point = transform;
        }
    }
}
