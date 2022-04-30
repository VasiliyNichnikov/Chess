namespace Figure
{
    public interface IFigure
    {
        public void Destroy(IDestruction destruction);

        public void Move(IMovement movement);
    }
}