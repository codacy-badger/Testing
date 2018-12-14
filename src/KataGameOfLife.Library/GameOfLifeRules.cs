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
            if (CurrentCell == CellState.Alive && Neighbour == 0)
                CurrentCell = CellState.Dead;
            if (CurrentCell == CellState.Alive && Neighbour == 1)
                CurrentCell = CellState.Dead;
            if (CurrentCell == CellState.Alive && Neighbour == 2)
                CurrentCell = CellState.Dead;
            if (CurrentCell == CellState.Alive && Neighbour == 3)
                CurrentCell = CellState.Alive;
            if (CurrentCell == CellState.Dead && Neighbour == 3)
                CurrentCell = CellState.Alive;
        }
    }
}