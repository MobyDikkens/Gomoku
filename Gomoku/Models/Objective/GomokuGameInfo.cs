using Gomoku.Models.Abstract;

namespace Gomoku.Models.Objective
{
    public class GomokuGameInfo : IGameInfo
    {
        private const int ColumnsCount = 19;
        private const int RowsCount = 19;

        int IGameInfo.ColumnsCount
        {
            get => ColumnsCount;
        }

        int IGameInfo.RowsCount
        {
            get => RowsCount;
        }
    }
}
