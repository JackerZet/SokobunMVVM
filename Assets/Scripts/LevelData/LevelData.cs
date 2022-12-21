using Sokobun.Views;
using UnityEngine;

namespace Sokobun.Data
{
    public class LevelData
    {
        public int[,] objects;
        public GameObject[,] gameObjects;

        public float OffsetX { get; }
        public float OffsetY { get; }
        
        public LevelData(float offsetX, float offsetY)
        {
            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        public GameObject this[int x, int y] => gameObjects[x, y];
        
        //public PlayerView[] players;
        //public PushableView[] pushables;
        //public WallView[] walls;
        //public VictoryTileView[] finishTiles;  
    }
}
