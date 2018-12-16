[![Build Status](https://travis-ci.org/AtefMlaouhi/BDD-Conway-s-Game-of-Life.svg?branch=master)](https://travis-ci.org/AtefMlaouhi/BDD-Conway-s-Game-of-Life)

[![license](https://img.shields.io/github/license/AtefMlaouhi/Kata-Conway-s-Game-of-Life.svg?maxAge=2592000)]()

# Game of life

The game is a zero-player game, meaning that its evolution is determined by its
initial state, requiring no further input. One interacts with the Game of Life by
creating an initial configuration and observing how it evolves, or, for advanced
players, by creating patterns with particular properties.

for more information see [wikipedia.org](http://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)

## Goals

We create a Behavior-driven development ([BDD](https://en.wikipedia.org/wiki/Behavior-driven_development))
to define a test set and finally verify that the implementation of the unit makes the tests succeed.

We create a method that takes in the current cell state (live/dead) and the
number of live neighbors and then spits out a new state (live/dead).

## Requirements :

- [Visual studio](https://visualstudio.microsoft.com/fr/?rr=https%3A%2F%2Fwww.google.com%2F) to run the application.
- .Net Framework 4.6.1
- [specflow](https://specflow.org/) Binding Business Requirements to .NET Code
- [Nunit](https://nunit.org/) Unit-testing framework for all .Net languages. 3.11.0
- [Fluent assertions](https://fluentassertions.com/) Assertions is Fluent 5.0.0

## User Stories

We start with a two dimensional grid of cells, where each cell is either alive or
dead. In this version of the problem, the grid is finite, and no life can exist
off the edges. When calcuating the next generation of the grid, follow these rules:

1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
2. Any live cell with more than three live neighbours dies, as if by overcrowding.
3. Any live cell with two or three live neighbours lives on to the next generation.
4. Any dead cell with exactly three live neighbours becomes a live cell.

## Credits

- Made by [Atef Mlaouhi](https://github.com/AtefMlaouhi).

## License

This project uses the [LGPL v3 License](https://www.gnu.org/licenses/lgpl-3.0.en.html) (See the LICENSE file in this repository).
