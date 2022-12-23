using System;
using UnityEngine;

namespace Sokobun.Inputs 
{
    public static class InputDirection
    {
        private static readonly (KeyCode, Vector2)[] _directions = new (KeyCode, Vector2)[]
        {
            (KeyCode.W, Vector2.up),
            (KeyCode.S, Vector2.down),
            (KeyCode.A, Vector2.left),
            (KeyCode.D, Vector2.right)
        };
        public static Vector2 GetDirection()
        {
            for(int i = 0; i < _directions.Length; i++)

                if (Input.GetKey(_directions[i].Item1))
                    return _directions[i].Item2;

            return Vector2.zero;
        }
    }
    public static class InputLayers
    {
        public const string TileLayerName = "Tile";
        public const int TileLayer = 6;
        public const int TileLayerMask = 1 << TileLayer;
    }
    public static class InputResources
    {
        public static T Load<T>(string path) where T : UnityEngine.Object
        {
            T component = Resources.Load<T>(path);
          
            if (component == null)
                throw new Exception($"The component in {path} is incorrectly named or missing from the resources folder");

            return component;
        }
        public static GameObject Load(string path) 
        {
            var component = (GameObject)Resources.Load(path);

            if (component == null)
                throw new Exception($"The component in {path} is incorrectly named or missing from the resources folder");

            return component;
        }
    }
}
