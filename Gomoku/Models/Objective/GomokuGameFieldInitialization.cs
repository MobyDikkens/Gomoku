using System.Windows.Controls;
using Gomoku.Models.Abstract;

namespace Gomoku.Models.Objective
{
    public class GomokuGameFieldInitialization : IGameFieldInitialization
    {
        void IGameFieldInitialization.SetColumns(Grid source, IGameInfo info)
        {
            //get the appropriative column count and create the instances
            for (int i = 0; i < info.ColumnsCount; i++)
            {
                source.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        void IGameFieldInitialization.SetRows(Grid source, IGameInfo info)
        {
            //get the appropriative rows count and create the instances
            for (int i = 0; i < info.RowsCount; i++)
            {
                source.RowDefinitions.Add(new RowDefinition());
            }
        }
    }
}
