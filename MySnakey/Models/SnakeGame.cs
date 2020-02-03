using MySnakey.Common;
using System;
using System.Windows.Threading;

namespace MySnakey.Models
{
    public class SnakeGame : NotificationBase
    {
        public Snake CurrentSnake { get; }
        public GameBoard Board { get; }
        private DispatcherTimer DispatcherTimer { get; set; }

        public SnakeGame()
        {
            Board = new GameBoard();
            OnPropertyChanged(nameof(Board));

            CurrentSnake = new Snake();
            OnPropertyChanged(nameof(CurrentSnake));

            DispatcherTimer = new DispatcherTimer();
            DispatcherTimer.Tick += DispatcherTimer_Tick;
            DispatcherTimer.Interval = TimeSpan.FromMilliseconds(Constants.TimePerMoveInMiliseconds);
            DispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
            => CurrentSnake.MoveSnake();

        internal void SetSnakeDirection(Direction direction) 
            => CurrentSnake.SetDirection(direction);
    }
}
