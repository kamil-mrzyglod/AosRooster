# AosRoster
A simple application for managing players and scores during AoS tournaments.

## Downloads
Current release is **1.1.0** which can be downloaded from release page - https://github.com/kamil-mrzyglod/AosRoster/releases/tag/1.1.0

## Installation
After extracting the ZIP archive just double-click **setup.exe** file, it'll guide you through the installation process.

## Usage

### Loading a rooster file
To start working with an application you have to prepare a rooster file. It can be a TXT or CSV file, where row contains two values - a player name and its faction, e.g.:

> Kamil;Nurgle  
> Joe;Order(Elves)  
> Jane;Destruction  
> Gork;Destruction

then you can go to **Plik** -> **Załaduj rooster** to load the file and players.

### Drawing players
When players are loaded, you can draw pairs for the next game(it'll randomly pair players loaded from the rooster) using **Wylosuj graczy** button.

### Adding a result
When players are loaded, you can add a result of a game for each pair.

Please have in mind, that drawing pairs(at least in the current release) doesn't care whether players have played with each other before so it's possible, that you'll get the same pair twice.

Adding a result of a game is pretty simple - just click on **Dodaj wynik** - it'll display a window where you can select players and enter points. The application will independently determine who won, who lost or whether it was a draw. 

Each time you add a result, it'll be added to **rooster.dat** file, which can be found in your Desktop directory. It contains all results and games and if any crash happens, you can restart the application and use **Plik** -> **Wczytaj wyniki** to restore the state.

### Adding a player
When players are loaded, you can add another player using **Gracze** -> **Dodaj gracza** menu. Please note that uneven number of players will disallow you from drawing new pairs!

### Editing a player
If you'd like to edit player's data(wins, loses etc.) just double-click on the value in the rooster table - you should be able to enter new value, which will update records automatically. Note that it will require you to check proper win/draw/loose ratio!

**Please note that it's still a beta version so any help - posting bugs, ideas or fixes - is much appreciated!**
