using UnityEngine;

namespace Sokobun.Infrastructure
{
    public interface ICreator<T> where T : MonoBehaviour
    {
        T FacroryMethod();
    }
}
