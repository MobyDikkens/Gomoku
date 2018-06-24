using Gomoku.Models.Abstract;
using Gomoku.Models.Objective;

namespace Gomoku.ViewModels
{
    public class MainWindowVM
    {
        //info about the target game
        private readonly IGameInfo _gameInfo;


        /// <summary>
        /// Information about the Gomoku game
        /// </summary>
        public IGameInfo GameInfo => _gameInfo;

        //Constructor
        public MainWindowVM()
        {
            //make an initialization via Gomoku
            _gameInfo = new GomokuGameInfo();
        }
    }
}
