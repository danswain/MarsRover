Feature: MarsRoverSquad
	In order to control a rover, 
	As NASA 
	I want to sends a simple string of letters to the RoverSquadControl

@acceptance
Scenario: Control 1 Rover in a 5x5 Plateau
	Given I have a RoverRoverSquadControl
	And I enter the command 5 5
	And I enter the command 1 1 N
	And I enter the command M
	When I enter the GO command
	Then the output should be 1 2 N
