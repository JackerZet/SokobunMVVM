using UnityEngine;

namespace Sokobun.Models
{
    public interface IMovingModel
    {
        Transform Movable { get; }
        Vector2 Direction { get; set; }
        void Move();
        void SetDirection(Vector2 direction);
    }
}