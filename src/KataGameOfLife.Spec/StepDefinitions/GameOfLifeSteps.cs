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
        [Given(@"initial ""(.*)"" state cell with \((.*)\) alive neighbours")]
        public void GivenInitialStateCellWithAliveNeighbours(CellState initSatate, int neighbour)
        {
            GameOfLifeRules.SetCurrentGeneration(initSatate, neighbour);
        }


        [When(@"I determine next generation")]
        public void WhenIDetermineNextGeneration()
        {
            GameOfLifeRules.SetNextGeneration();
        }

        [Then(@"next generation is ""(.*)""")]
        public void ThenNextGenerationIs(CellState result)
        {
            Assert.That(GameOfLifeRules.CurrentCell.Equals(result));
        }
    }
}
