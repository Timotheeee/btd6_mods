How to use
(you need to have sauda unlocked to use it)
Press F2 to toggle it on and off (do it while in a game)
Press ctrl+F3 to reset the AI if it starts to use the same bad strategy over and over
Press F1 if you want to load the networks from the last generation
I highly recommend using the speedhack with this. This mod has the side effect of making the rounds start automatically when loading a save.
It can usually beat most beginner maps on chimps  (with 700 starting cash) after a few generations, if not then reset it


More info on how it works
The AI is a (multi-layer)neural network that knows what the current round is and then outputs which tower should be placed (there is a list of allowed towers)
It always starts with Sauda, for the sake of beating the early game. The mod then automatically places and upgrades the tower the AI wants to place. Once that is done, the AI chooses the next tower until the game ends. The AI also chooses the section of the map where the tower should be placed (how far along the track, 9 possibilities).
You can see what it wants to do in the console.
At the start the mod generates 15 random networks (1 generation), once they have all played it takes the best ones and randomly modifies them in hopes that they might get slightly better.
If you have experience with machine learning I suggest you download the source and try to improve it with whatever ideas you might have.