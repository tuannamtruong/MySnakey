using MySnakey.Common;

namespace MySnakey.Models
{
    public class GameElementInBoard : NotificationBase
    {
        #region Fields

        protected int positionXInPixel;
        protected int positionYInPixel;
        protected int width;
        protected int height;

        #endregion

        #region Properties

        public int PositionXInPixel
        {
            get => positionXInPixel;
            set
            {
                positionXInPixel = value;
                OnPropertyChanged();
            }
        }
        public int PositionYInPixel
        {
            get => positionYInPixel;
            set
            {
                positionYInPixel = value;
                OnPropertyChanged();
            }
        }
        public int Width
        {
            get => width;
            private set => width = value;
        }
        public int Height
        {
            get => height;
            private set => height = value;
        }

        #endregion

        #region Constructors

        public GameElementInBoard() { }

        public GameElementInBoard(int positionXInPixel, int positionYInPixel, int width, int height)
        {
            PositionXInPixel = positionXInPixel;
            PositionYInPixel = positionYInPixel;
            Width = width;
            Height = height;
        }

        #endregion
    }
}
