using MySnakey.Common;
using System;
using System.Collections.ObjectModel;

namespace MySnakey.Models
{
    public class Snake : NotificationBase
    {
        public SnakeHead Head { get; set; }

        private ObservableCollection<SnakeBody> body;
        public ObservableCollection<SnakeBody> Body
        {
            get => body;
            set
            {
                body = value;
                OnPropertyChanged();
            }
        }

        public Snake()
        {
            Head = new SnakeHead(
                Constants.SnakeInitialXposition, Constants.SnakeInitialYposition,
                Constants.SnakeDefaultWidthPixels, Constants.SnakeDefaultHeightPixels,
                Constants.SnakeInitialDirection);

            SnakeBody firstPart = new SnakeBody(Head);
            SnakeBody secondPart = new SnakeBody(firstPart);
            Body = new ObservableCollection<SnakeBody>
            {
                firstPart,
                secondPart
            };
        }

        internal void MoveSnake()
        {
            MoveSnakeHead();
            MoveSnakeBody();
        }

        private void MoveSnakeHead()
        {
            switch (Head.CurrentDirection)
            {
                case Direction.Up:
                    Head.PositionYInPixel -= Constants.AmountOfPixelsPerMove;
                    break;
                case Direction.Down:
                    Head.PositionYInPixel += Constants.AmountOfPixelsPerMove;
                    break;
                case Direction.Left:
                    Head.PositionXInPixel -= Constants.AmountOfPixelsPerMove;
                    break;
                case Direction.Right:
                    Head.PositionXInPixel += Constants.AmountOfPixelsPerMove;
                    break;
            }
        }
        private void MoveSnakeBody()
        {
            foreach (SnakeBody bodyPart in Body)
            {
                bodyPart.Move();
            }
        }

        internal void SetDirection(Direction newDirection)
        {
            if (!IsOppositeDirection(Head.CurrentDirection, newDirection))
            {
                Head.CurrentDirection = newDirection;
            }
        }

        private bool IsOppositeDirection(Direction current, Direction newDirection)
        {
            switch (current)
            {
                case Direction.Up when newDirection == Direction.Down:
                case Direction.Down when newDirection == Direction.Up:
                case Direction.Left when newDirection == Direction.Right:
                case Direction.Right when newDirection == Direction.Left:
                    return true;
            }
            return false;
        }
    }
}