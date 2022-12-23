using Sokobun.Inputs;
using Sokobun.Victory;
using Sokobun.ViewModels;
using System.Collections.Generic;
using UnityEngine;

namespace Sokobun.Data
{
    public class LevelData
    {
        public int[,] objects;
        public GameObject[,] gameObjects;

        public readonly LevelConfig levelConfig;
        public readonly List<IMovingViewModel> movables = new();
        public readonly List<IVictoryViewModel> victories = new();
        public readonly VictoryCaretaker victoryCaretaker;

        public float OffsetX { get; }
        public float OffsetY { get; }
        
        public LevelData(float offsetX, float offsetY)
        {
            levelConfig = InputResources.Load<LevelConfig>(nameof(LevelConfig));
            victoryCaretaker = new VictoryCaretaker(levelConfig.QuantityPressedTilesToWin);

            OffsetX = offsetX;
            OffsetY = offsetY;
        }

        public GameObject this[int x, int y] => gameObjects[x, y];

        
    }
}
