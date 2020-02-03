using MySnakey.Models;

namespace MySnakey.Common
{
    public class Constants
    {
        // Game board constants
        public const int GameBoardWidthPixels = 1000;
        public const int GameBoardHeightPixels = 1000;
        // Snake size
        public const int SnakeDefaultWidthPixels = 20;
        public const int SnakeDefaultHeightPixels = 20;
        // Snake initial position
        public const int SnakeInitialXposition = 200;
        public const int SnakeInitialYposition = 200;
        // Snake movement
        public const Direction SnakeInitialDirection = Direction.Right;
        public const int AmountOfPixelsPerMove = 20;
        public const double TimePerMoveInMiliseconds = 200;
    }
}
