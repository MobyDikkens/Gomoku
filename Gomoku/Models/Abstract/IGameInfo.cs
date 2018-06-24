namespace Gomoku.Models.Abstract
{
    /// <summary>
    /// Represents information about an appropriative game
    /// </summary>
    public interface IGameInfo
    {
        int ColumnsCount { get; }
        int RowsCount { get; }
    }
}
