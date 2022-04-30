using UnityEngine;

namespace Figure
{
    public class Destruction : IDestruction
    {
        private readonly GameObject _gameObject;

        public Destruction(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        
        public void Destroy()
        {
            Object.Destroy(_gameObject);
        }
    }
}