Feature: Game Of Life
	As a "Game of Life" observer
	In order to play The game with a zero-player
	I want analyse state and observing how it evolved


Scenario: A live cell with all neighbours dead :	0	0
													0	1
	Given initial a live (1) state cell with three dead (3) neighbours
	When I determine next generation: with three dead neighbours
	Then next generation is dead (0): with three dead neighbours


Scenario: A live cell with all neighbours dead :	0	1
													0	1
	Given initial a live (1) state cell: with two dead (2) neighbours
	When I determine next generation: with tow dead neighbours
	Then next generation is dead (0): with tow dead neighbours

