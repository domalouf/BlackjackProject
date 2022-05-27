Welcome to my Blackjack Simulator and Teacher Program!

Strategy:
This class holds the moves that come from the basic strategy table.

Its constructor is very specific to read in the file given by BasicStrategyChart.txt in Resources.

I hope there is a better way of reading in charts to 2D arrays because my method was very arduous to implement.

MVC Architecture:
This program uses Model View Controller to handle seperation of concerns for the different projects.

View has a reference to model and controller.
The controller owns the model, but the view has a reference.
It displays all information to the user

Controller has a reference to model.
The model object is contained in the controller
It is simple before a connection to a server is required.

Model contains all information about players and physical parts of Blackjack.
It contains information on basic strategy.
It is manipulated by the controller and looked at by the view.

TODO:
make basic view that can take in what cards are in play and give player the correct move to make (DONE)
give player ability to hit until 21

have different tools in different windows, so not all crammed in the same designer
different tools like deal cards or get basic strategy