Feature: Game Of Life
	As a "Game of Life" observer
	In order to play The game with a zero-player
	I want analyse state and observing how it evolved


Scenario: Alive cell with zero neighbours alive:	0	0
													0	1
	Given initial alive (1) state cell with zero alive (0) neighbour
	When I determine next generation
	Then next generation is dead (0)


Scenario: Alive cell with one neighbour alive:	0	1
												0	1
	Given initial a live (1) state cell with one alive (1) neighbour
	When I determine next generation
	Then next generation is dead (0)

Scenario: Alive cell with two neighbours alive:	1	1
												0	1
	Given initial a live (1) state cell with two alive (2) neighbours
	When I determine next generation
	Then next generation is dead (0)

Scenario: A live cell with three neighbours alive:	1	1
													1	1
	Given initial a live (1) state cell with three alive (3) neighbours
	When I determine next generation
	Then next generation is alife (1)


Scenario: Dead cell with zero neighbours alive:	0	0
												0	0
	Given initial dead (0) state cell with zero alive (0) neighbour
	When I determine next generation
	Then next generation is dead (0)

Scenario: Dead cell with one neighbour alive:	0	1
												0	0
	Given initial dead (0) state cell with one alive (1) neighbour
	When I determine next generation
	Then next generation is dead (0)

Scenario: Dead cell with two neighbours alive:	1	1
												0	0
	Given initial dead (0) state cell with tow alive (2) neighbours
	When I determine next generation
	Then next generation is dead (0)

Scenario: Dead cell with three neighbours alive:	1	1
													1	0
	Given initial dead (0) state cell: with three alive (3) neighbours
	When I determine next generation
	Then next generation is alife (1)

Scenario: Dead cell with more than three neighbours alive:	1	1	1
															1	0	1
															0	0	0
	Given initial dead (0) state cell: with more than three alive (4) neighbours
	When I determine next generation
	Then next generation is dead (0)

Scenario: Alive cell with more than three neighbours alive:	1	1	1
															1	1	1
															0	0	0
	Given initial alive (1) state cell: with more than three alive (4) neighbours
	When I determine next generation
	Then next generation is dead (0)