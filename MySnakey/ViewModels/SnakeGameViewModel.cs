using MySnakey.Common;
using MySnakey.Models;
using System.Windows.Input;

namespace MySnakey.ViewModels
{
    public class SnakeGameViewModel
    {
        public SnakeGame CurrentSnakeGame { get; } = new SnakeGame();

        public SnakeGameViewModel()
        {
            // Maybe relevant for new game - restart
            //CurrentSnakeGame = new SnakeGame();

            // Setup EventHandlers for Snake's movement
            UpKeyPressedCommand = new DelegateCommand(OnUpKeyPressed);
            DownKeyPressedCommand = new DelegateCommand(OnDownKeyPressed);
            LeftKeyPressedCommand = new DelegateCommand(OnLeftKeyPressed);
            RightKeyPressedCommand = new DelegateCommand(OnRightKeyPressed);
        }

        #region Movement Commands

        public ICommand UpKeyPressedCommand { get; } 
        public ICommand DownKeyPressedCommand { get; } 
        public ICommand LeftKeyPressedCommand { get; } 
        public ICommand RightKeyPressedCommand { get; }

        #endregion

        #region Command Handlers

        private void OnUpKeyPressed(object obj) 
            => CurrentSnakeGame.SetSnakeDirection(Direction.Up);

        private void OnDownKeyPressed(object obj) 
            => CurrentSnakeGame.SetSnakeDirection(Direction.Down);

        private void OnRightKeyPressed(object obj) 
            => CurrentSnakeGame.SetSnakeDirection(Direction.Right);

        private void OnLeftKeyPressed(object obj) 
            => CurrentSnakeGame.SetSnakeDirection(Direction.Left);

        #endregion
    }
}
