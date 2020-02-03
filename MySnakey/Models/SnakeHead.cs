namespace MySnakey.Models
{
    public class SnakeHead : SnakePart
    {
        public SnakeHead(int positionXInPixel, int positionYInPixel, int width, int height, Direction direction)
            : base(positionXInPixel, positionYInPixel, width, height, direction)
        {
        }
    }
}
