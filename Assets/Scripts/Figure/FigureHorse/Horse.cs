using UnityEngine;

namespace Figure.FigureHorse
{
    public class Horse: MonoBehaviour, IFigure
    {
        public void Destroy(IDestruction destruction)
        {
            destruction.Destroy();
        }

        public void Move(IMovement movement)
        {
            movement.Go();
        }
    }
}