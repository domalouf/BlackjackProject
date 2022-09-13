Welcome to my Blackjack Simulator and Teacher Program!

Strategy:
This class holds the moves that come from the basic strategy table.

Its constructor is very specific to read in the file given by BasicStrategyChart.txt in Resources.

MVC Architecture:
This program uses Model View Controller to handle seperation of concerns for the different projects.

Model contains all information about players and physical parts of Blackjack.
It contains information on basic strategy.
It is manipulated by the controller and looked at by the view.

View has a reference to model and controller.
The controller owns the model, but the view has a reference.
It displays all information to the user

Controller has a reference to model.
The model object is contained in the controller
It is simple before a connection to a server is required.
Ivokes methods in the view using events

In English:
Model - the heart and soul, what the program is trying to replicate, on its own
View - View sees model but can't change it, uses controller to change model
Controller - handles input, updates model and view

BlackJack Game Loop (once player is bought in)
Starts By view asking for bet and number of hands
Once deal hands button is pressed, controller is called to deal hands
This gives all hands and dealer 2 cards and takes chips from stack
Checks for dealer blackjack and finishes round if there is,
Checks first hand for blackjack, if there is go to next hand (if one hand go to )
View asks for player input
If player hits the controller gives another card and checks for bust or 21
If player doubles the controller takes double the bet, hits, and then moves to next hand
If player splits the controller adds a hand and hits both hands
If player stands the controller calls for the view to show the next hand
	if more hand(s) to play the next hand appears to the view
	if last hand was stood on, the dealer finishes and chips are payed out


Helpful Link about MVC - https://www.cs.cornell.edu/courses/cs2112/2020fa/recitations/08patterns/Recitation8.pdf

TODO/BUGS:
dont play 3rd hand BUG
blackjack pays too much BUG
multiple hands with blackjack might be strange BUG
pick individual bets for hands TODO