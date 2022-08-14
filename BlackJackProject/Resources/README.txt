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



Helpful Link about MVC - https://www.cs.cornell.edu/courses/cs2112/2020fa/recitations/08patterns/Recitation8.pdf

TODO:
double down and split
play many hands to start an option