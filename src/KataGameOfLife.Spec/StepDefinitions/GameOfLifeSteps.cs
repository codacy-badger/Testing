using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace KataSpec.StepDefinitions
{
    [Binding]
    public class GameOfLifeSteps
    {
        private IGameOfLifeRules _gameOfLifeRules;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _gameOfLifeRules = new GameOfLifeRules();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _gameOfLifeRules = null;
        }

        [Given(@"initial a live \((.*)\) state cell with three dead \((.*)\) neighbours")]
        public void GivenInitialALiveStateCellWithThreeDeadNeighbours(int p0, int p1)
        {
            _gameOfLifeRules.SetInitialGenearation(p0, p1);
        }
        
        [Given(@"initial a live \((.*)\) state cell: with two dead \((.*)\) neighbours")]
        public void GivenInitialALiveStateCellWithTwoDeadNeighbours(int p0, int p1)
        {
            _gameOfLifeRules.SetInitialGenearation(p0, p1);
        }

        [When(@"I determine next generation: with three dead neighbours")]
        public void WhenIDetermineNextGenerationWithThreeDeadNeighbours()
        {
            _gameOfLifeRules.GetNewGeneration();
        }

        [When(@"I determine next generation: with tow dead neighbours")]
        public void WhenIDetermineNextGenerationWithTowDeadNeighbours()
        {
            _gameOfLifeRules.GetNewGeneration();
        }

        [Then(@"next generation is dead \((.*)\): with three dead neighbours")]
        public void ThenNextGenerationIsDeadWithThreeDeadNeighbours(int p0)
        {
            _gameOfLifeRules.CurrentState.Should().Equals(p0);
        }
        
        [Then(@"next generation is dead \((.*)\): with tow dead neighbours")]
        public void ThenNextGenerationIsDeadWithTowDeadNeighbours(int p0)
        {
            _gameOfLifeRules.CurrentState.Should().Equals(p0);
        }
    }
}
