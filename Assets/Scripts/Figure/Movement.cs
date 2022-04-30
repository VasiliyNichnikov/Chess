using UnityEngine;

namespace Figure
{
    public class Movement: IMovement
    {
        private readonly Transform _transform;
        private readonly Vector3 _position;

        public Movement(Transform transform, Vector3 position)
        {
            _transform = transform;
            _position = position;
        }
        
        
        public void Go()
        {
            _transform.position = _position;
        }
    }
}