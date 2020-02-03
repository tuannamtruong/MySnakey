using MySnakey.Common;

namespace MySnakey.Models
{
    public class GameBoard : NotificationBase
    {
        public int WidthPixels { get; } = Constants.GameBoardWidthPixels;
        public int HeightPixels { get; } = Constants.GameBoardHeightPixels;

        public GameBoard() { }
    }
}