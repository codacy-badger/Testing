using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using FluentAssertions;
using KataGameOfLife.Spec.Library;

namespace KataGameOfLife.Spec.StepDefinitions
{
    [Binding]
    public class GameOfLifeSteps
    {
        [Given(@"initial alive \((.*)\) state cell with zero alive \((.*)\) neighbour")]
        public void GivenInitialAliveStateCellWithZeroAliveNeighbour(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial a live \((.*)\) state cell with one alive \((.*)\) neighbour")]
        public void GivenInitialALiveStateCellWithOneAliveNeighbour(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial a live \((.*)\) state cell with two alive \((.*)\) neighbours")]
        public void GivenInitialALiveStateCellWithTwoAliveNeighbours(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial a live \((.*)\) state cell with three alive \((.*)\) neighbours")]
        public void GivenInitialALiveStateCellWithThreeAliveNeighbours(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial dead \((.*)\) state cell with zero alive \((.*)\) neighbour")]
        public void GivenInitialDeadStateCellWithZeroAliveNeighbour(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial dead \((.*)\) state cell with one alive \((.*)\) neighbour")]
        public void GivenInitialDeadStateCellWithOneAliveNeighbour(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial dead \((.*)\) state cell with tow alive \((.*)\) neighbours")]
        public void GivenInitialDeadStateCellWithTowAliveNeighbours(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial dead \((.*)\) state cell: with more than three alive \((.*)\) neighbours")]
        public void GivenInitialDeadStateCellWithMoreThanThreeAliveNeighbours(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial dead \((.*)\) state cell: with three alive \((.*)\) neighbours")]
        public void GivenInitialDeadStateCellWithThreeAliveNeighbours(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [Given(@"initial alive \((.*)\) state cell: with more than three alive \((.*)\) neighbours")]
        public void GivenInitialAliveStateCellWithMoreThanThreeAliveNeighbours(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }

        [When(@"I determine next generation")]
        public void WhenIDetermineNextGeneration()
        {
            GameOfLifeRules.SetNextGeneration();
        }

        [Then(@"next generation is dead \((.*)\)")]
        public void ThenNextGenerationIsDead(CellState result)
        {
            Assert.That(GameOfLifeRules.CurrentCell.Equals(result));
        }

        [Then(@"next generation is alife \((.*)\)")]
        public void ThenNextGenerationIsAlife(CellState result)
        {
            Assert.That(GameOfLifeRules.CurrentCell.Equals(result));
        }
    }
}
