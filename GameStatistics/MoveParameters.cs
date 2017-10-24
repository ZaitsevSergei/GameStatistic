using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPAM.TicTacToe;
namespace _2017.Gomoku.FirstTeam.GameStatistics.Zaitsev
{
    public class MoveParameters 
    {
        public CellState.cellState PlayerID { get; set; }
        public int MoveID { get; set; }                     // номер хода
        public DateTime MoveTime { get; set; }              // время, затраченное на ход
        public DateTime WholeTime { get; set; }             // время потраченное на все ходы на момент текущего хода

        public MoveParameters() { }

        public MoveParameters(CellState.cellState playerID, int moveID, DateTime moveTime, DateTime wholeTime)
        {
            PlayerID = playerID;
            MoveID = moveID;
            MoveTime = moveTime;
            WholeTime = wholeTime;
        }        
    }
}
