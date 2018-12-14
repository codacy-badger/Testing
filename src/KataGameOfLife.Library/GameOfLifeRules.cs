using System;

namespace KataGameOfLife.Spec.Library
{
    [Flags]
    public enum CellState
    {
        Dead = 0,
        Alive = 1
    }

    public class GameOfLifeRules
    {
        public static CellState CurrentCell { get; set; } = CellState.Dead;
        private static int Neighbour { get; set; }

        public static void SetCurrentGeneration(CellState currentCell, int neighbour)
        {
            CurrentCell = currentCell;
            Neighbour = neighbour;
        }

        public static void SetNextGeneration()
        {
            if (Neighbour == 3)
                CurrentCell = CellState.Alive;
            else
                CurrentCell = CellState.Dead;
        }
    }
}