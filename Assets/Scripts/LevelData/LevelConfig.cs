using UnityEngine;

namespace Sokobun.Data
{
    [CreateAssetMenu(fileName = "Level config", menuName = "Scriptable object/Config/Level config", order = 1)]
    public class LevelConfig : ScriptableObject
    {
        [field: SerializeField] public float Delay { get; private set; }
        [field: SerializeField] public int QuantityPressedTilesToWin { get; private set; }

    }
}