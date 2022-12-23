using Sokobun.Data;
using Sokobun.Inputs;
using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Game
{
    public class TypeConverter
    {
        public static readonly string[] ides = new string[]
        {
            null,
            nameof(WallView),
            nameof(PlayerView),
            nameof(PushableView),
            nameof(VictoryTileView)
        };
        //public readonly GameObject[] prefabs;
        private readonly LevelData _data;
        public TypeConverter(LevelData data)
        {
            //prefabs = new GameObject[QuantityOfTypes];

            //for (int i = 1; i < QuantityOfTypes; i++)
            //    prefabs[i] = InputResources.Load(ides[i]);
            
            _data = data;
        }
        public static int QuantityOfTypes => ides.Length;
        
        //public GameObject Convert(int x, int y, int i)
        //{           
        //    return 
        //}
        //public int Convert(int x, int y, GameObject gameObject)
        //{
        //    _data.
        //}
    }
}
