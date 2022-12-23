using Sokobun.Data;
using Sokobun.Inputs;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

namespace Sokobun.Game
{
    public sealed class Starter : MonoBehaviour
    {
        private GameInitialization _init;
        private LevelData _data;
        private Enumerator _enumerator;

        private float delay;
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

            delay = _data.levelConfig.Delay;
            _enumerator = new Enumerator(delay);      
        }
        private void Update()
        {             
            if (Input.anyKeyDown)
            {
                _enumerator.ResetEnumerator();
                UpadateObjects();
            }
            else if (_enumerator.CanDo() && Input.anyKey) 
            {
                UpadateObjects();
            }
        }
        private void UpadateObjects()
        {
            for (int i = 0; i < _data.movables.Count; i++)
                _data.movables[i].Direction = InputDirection.GetDirection();

            for (int i = 0; i < _data.movables.Count; i++)
                _data.movables[i].Move();

            for (int i = 0; i < _data.victories.Count; i++)
                _data.victories[i].IsPressed();

            if (_data.victoryCaretaker.IsWin)
                Debug.Log("u win, les go");
        }
    }
}
