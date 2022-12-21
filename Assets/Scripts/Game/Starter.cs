using Sokobun.Data;
using System.Collections.Generic;
using UnityEngine;

namespace Sokobun.Game
{
    public sealed class Starter : MonoBehaviour
    {
        private GameInitialization _init;
        private LevelData _data;
        private void Awake()
        {
            _init = new GameInitialization(new int[,]
                {
                    { 1, 1, 1, 1, 0, 1, 1, 1},
                    { 1, 2, 0, 1, 1, 1, 4, 1},
                    { 1, 0, 3, 0, 0, 1, 4, 1},
                    { 1, 0, 3, 0, 0, 0, 4, 1},
                    { 1, 1, 3, 0, 0, 3, 4, 1},
                    { 0, 1, 0, 0, 0, 1, 1, 1},
                    { 0, 1, 1, 1, 1, 1, 0, 0},
                },out _data);
            //_init.CreateLevel();
        }
        private void Update()
        {
             
        }
    }
}
