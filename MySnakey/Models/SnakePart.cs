namespace MySnakey.Models
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public class SnakePart : GameElementInBoard
    {
        protected Direction currentDirection;
        public Direction CurrentDirection
        {
            get => currentDirection;
            set
            {
                currentDirection = value;
                OnPropertyChanged();
            }
        }

        public SnakePart() { }
        public SnakePart(int positionXInPixel, int positionYInPixel, int width, int height, Direction direction)
        : base(positionXInPixel, positionYInPixel, width, height)
        {
            currentDirection = direction;
        }
    }
}
