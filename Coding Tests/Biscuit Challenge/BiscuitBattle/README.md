# Biscuit Battle
This class library and console library demonstrate how you might create a simple top trumps style game. It's not perfect by any means but it does make use of a few concepts that may or may not be familiar to graduate developers.
This codebase is part of Selenity's hiring process but anyone is free to take a look!

## Rules
Players both take a card from the top of their deck. They then take it in turns to pick an attribute from their card to compare against their opponent. If the score is higher for your selected attribute, you take the opponent's card. The player who runs out of cards first loses.


## IPlayer
An IPlayer is an interface that defines an entity that may take part in the game.

## IBiscuitCard
An interface that defines a card that can be included in the deck. It must include top trump style stats, a name, and a description.

## IGameController
This interface defines the game controller - the object that is respondsible for running the game and deciding on a winner. In theory you could create new implimentations of 
this that changed the rules

## Service Locator Pattern
The codebase uses a simple service locator to load concrete types at runtime

## Factory
A factory pattern is used to generate a random deck of cards

For more information on this codebase and for your required tasks, please consult the document that you will have been provided with.

Thanks.