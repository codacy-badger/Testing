Feature: Game Of Life
	As a "Game of Life" observer
	In order to play The game with a zero-player
	I want analyse state and observing how it evolved


Scenario: Alive cell with zero neighbours alive:	0	0
													0	1
	Given initial "Alive" state cell with (0) alive neighbours
	When I determine next generation
	Then next generation is "Dead"


Scenario: Alive cell with one neighbour alive:	0	1
												0	1
	Given initial "Alive" state cell with (1) alive neighbours
	When I determine next generation
	Then next generation is "Dead"

Scenario: Alive cell with two neighbours alive:	1	1
												0	1
	Given initial "Alive" state cell with (2) alive neighbours
	When I determine next generation
	Then next generation is "Alive"

Scenario: A live cell with three neighbours alive:	1	1
													1	1
	Given initial "Alive" state cell with (3) alive neighbours
	When I determine next generation
	Then next generation is "Alive"

Scenario: Dead cell with zero neighbours alive:	0	0
												0	0
	Given initial "Dead" state cell with (0) alive neighbours
	When I determine next generation
	Then next generation is "Dead"

Scenario: Dead cell with one neighbour alive:	0	1
												0	0
	Given initial "Dead" state cell with (1) alive neighbours
	When I determine next generation
	Then next generation is "Dead"

Scenario: Dead cell with two neighbours alive:	1	1
												0	0
	Given initial "Dead" state cell with (2) alive neighbours
	When I determine next generation
	Then next generation is "Dead"

Scenario: Dead cell with three neighbours alive:	1	1
													1	0
	Given initial "Dead" state cell with (3) alive neighbours
	When I determine next generation
	Then next generation is "Alive"

Scenario: Dead cell with more than three neighbours alive:	1	1	1
															1	0	1
															0	0	0
	Given initial "Dead" state cell with (4) alive neighbours
	When I determine next generation
	Then next generation is "Dead"

Scenario: Alive cell with more than three neighbours alive:	1	1	1
															1	1	1
															0	0	0
	Given initial "Alive" state cell with (4) alive neighbours
	When I determine next generation
	Then next generation is "Dead"