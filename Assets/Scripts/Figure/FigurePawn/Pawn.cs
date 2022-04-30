using UnityEngine;

namespace Figure.FigurePawn
{
    public class Pawn: MonoBehaviour, IFigure
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