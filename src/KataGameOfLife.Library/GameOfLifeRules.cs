using System;

namespace KataGameOfLife.Spec.Library
{
    [Flags]
    public enum GenerationState
    {
        Dead = 0,
        Alive = 1
    }

    public class GameOfLifeRules
    {
        public static GenerationState CurrentCell { get; set; } = GenerationState.Dead;
        private static int NeighbourALive { get; set; }

        public static void SetCurrentGeneration(GenerationState currentCell, int neighbourALive)
        {
            CurrentCell = currentCell;
            NeighbourALive = neighbourALive;
        }

        public static void SetNextGeneration()
        {
            switch (CurrentCell)
            {
                case GenerationState.Alive:
                    if (NeighbourALive < 2 || NeighbourALive > 3)
                        CurrentCell = GenerationState.Dead;
                    break;
                case GenerationState.Dead:
                    if (NeighbourALive == 3)
                        CurrentCell = GenerationState.Alive;
                    break;
            }
        }
    }
}