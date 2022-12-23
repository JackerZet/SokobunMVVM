using static UnityEngine.Object;
using Sokobun.Views;
using UnityEngine;
using Sokobun.Data;
using Sokobun.Infrastructure;
using System.Collections.Generic;
using System;

namespace Sokobun.Game
{
    public class GameInitialization
    {
        #region Readonly
        private readonly int length, width;
        private readonly float offsetX, offsetY;
        
        private readonly LevelData _data;

        private readonly ICreator<PlayerView> _playerCreator = new PlayerCreator();
        private readonly ICreator<PushableView> _pushableCreator = new PushableCreator();
        private readonly ICreator<WallView> _wallCreator = new WallCretor();
        private readonly ICreator<VictoryTileView> _victoryTileCreator;

        private readonly TypeConverter _typeConverter;

        private readonly Dictionary<string, Action<Vector2>> _actionMap; 
        #endregion

        public GameInitialization(int[,] objects, out LevelData levelData)
        { 
            length = objects.GetLength(0);
            width = objects.GetLength(1);
      
            offsetX = ((float)length) / 2;
            offsetY = ((float)width) / 2 - 1;

            levelData = new LevelData(offsetX, offsetX);

            _data = levelData;
            _data.objects = objects;

            _victoryTileCreator = new VictoryTileCreator(_data.victoryCaretaker);

            _typeConverter = new(_data);

            _actionMap = CreateActionMap();
            
            CreateLevel();
        }
        private Dictionary<string, Action<Vector2>> CreateActionMap()
        {
            return new Dictionary<string, Action<Vector2>>
            {
                {nameof(WallView), (position)=>{

                    _wallCreator.FacroryMethod().transform.position = position; }
                },
                {nameof(PlayerView), (position)=>{

                    var player = _playerCreator.FacroryMethod();
                    player.transform.position = position;
                    _data.movables.Add(player.MovingViewModel);}
                },
                {nameof(PushableView), (position)=>{

                    var pushable = _pushableCreator.FacroryMethod();
                    pushable.transform.position = position;
                    _data.movables.Add(pushable.MovingViewModel); }
                },
                {nameof(VictoryTileView), (position)=>{

                    var victoryTile = _victoryTileCreator.FacroryMethod();
                    victoryTile.transform.position = position;
                    _data.victories.Add(victoryTile.VictoryViewModel); }
                }
            };
        }
        public void CreateLevel()
        {
            _data.gameObjects = new GameObject[length, width];
         
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < width; j++)
                {                  
                    if (_data.objects[i, j] == 0) continue;

                    var position = new Vector2(j - offsetX, offsetY - i);

                    var index = TypeConverter.ides[_data.objects[i, j]];

                    _actionMap[index].Invoke(position);
                }
            }   
        }       
    }
}
