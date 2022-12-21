using static UnityEngine.Object;
using Sokobun.Views;
using UnityEngine;
using Sokobun.Data;
using Sokobun.Infrastructure;

namespace Sokobun.Game
{
    public class GameInitialization
    {
        #region Readonly
        private readonly int length, width;
        private readonly float offsetX, offsetY;
        
        private readonly LevelData _data;
        //private readonly int[,] _objects;

        private ICreator<PlayerView> _playerCreator = new PlayerCreator();
        private ICreator<PushableView> _pushableCreator = new PushableCreator();

        private readonly TypeConverter _typeConverter;
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

            _typeConverter = new(_data);
                     
            CreateLevel();
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
                    _data.gameObjects[i, j] = Instantiate(_typeConverter.prefabs[_data.objects[i, j]], position, Quaternion.identity);
                }
            }   
        }      
    }
}
