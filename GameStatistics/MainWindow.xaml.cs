using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EPAM.TicTacToe;
namespace _2017.Gomoku.FirstTeam.GameStatistics.Zaitsev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<MoveParameters> Player1Moves { get; set; }
        Stack<MoveParameters> Player2Moves { get; set; }
        List<Stack<MoveParameters>> PlayersMoves { get; set; }
        List<DataGrid> playersTables;

        public MainWindow()
        {
            InitializeComponent();
            InitStatisticsUI();
        }

        private void InitStatisticsUI()
        {
            
            Player1Moves = new Stack<MoveParameters>();
            Player2Moves = new Stack<MoveParameters>();
            PlayersMoves = new List<Stack<MoveParameters>>();
            PlayersMoves.Add(Player1Moves);
            PlayersMoves.Add(Player2Moves);
            playersTables.Add(Player1_Table);
            playersTables.Add(Player2_Table);
        }

        public void GetMoveParameters(CellState.cellState playerID, int moveID, DateTime moveTime, DateTime wholeTime)
        {
            PlayersMoves[(int)playerID].Push(new MoveParameters(playerID, moveID, moveTime, wholeTime));
            playersTables[(int)playerID].ItemsSource = PlayersMoves[(int)playerID];
            playersTables[(int)playerID].Items.Refresh();
        }
    }
}
