using System.Windows.Controls;

namespace Gomoku.Models.Abstract
{
    /// <summary>
    /// Fill the game field using information exposed by the IGameInfo
    /// </summary>
    public interface IGameFieldInitialization
    {
        void SetColumns(Grid source, IGameInfo info);
        void SetRows(Grid source, IGameInfo info);
    }
}
