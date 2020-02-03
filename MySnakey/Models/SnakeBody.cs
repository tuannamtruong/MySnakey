namespace MySnakey.Models
{
    public class SnakeBody : SnakePart
    {
        #region Fields

        private SnakePart previousSnakePart;
        private int previousSnakePartLastPositionX;
        private int previousSnakePartLastPositionY;

        #endregion

        public SnakePart PreviousSnakePart
        {
            get => previousSnakePart;
            set
            {
                previousSnakePart = value;
                OnPropertyChanged();
            }
        }

        #region Constructors

        public SnakeBody() { }

        public SnakeBody(SnakePart previousSnakePart)
        {
            PreviousSnakePart = previousSnakePart;
            PositionXInPixel = previousSnakePartLastPositionX = previousSnakePart.PositionXInPixel;
            PositionYInPixel = previousSnakePartLastPositionY = previousSnakePart.PositionYInPixel;
        }

        #endregion

        #region Methods

        internal void Move()
        {
            PositionXInPixel = previousSnakePartLastPositionX;
            PositionYInPixel = previousSnakePartLastPositionY;
            previousSnakePartLastPositionX = previousSnakePart.PositionXInPixel;
            previousSnakePartLastPositionY = previousSnakePart.PositionYInPixel;
        }

        #endregion
    }
}
