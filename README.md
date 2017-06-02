# AosRooster
A simple application for managing players and scores during AoS tournaments.

## Downloads
Current release is **1.0.0** which can be downloaded from release page - https://github.com/kamil-mrzyglod/AosRooster/releases/tag/1.0.0

## Installation
After extracting the ZIP archive just double-click **setup.exe** file, it'll guide you through the installation process.

## Usage
To start working with an application you have to prepare a rooster file. It can be a TXT or CSV file, where row contains two values - a player name and its faction, e.g.:

> Kamil;Nurgle  
> Joe;Order(Elves)  
> Jane;Destruction  
> Gork;Destruction

then you can go to **Plik** -> **Załaduj rooster** to load the file and players. When players are loaded, you have two possibilities:
* draw pairs for the next game(it'll randomly pair players loaded from the rooster) using **Wylosuj graczy** button
* add a result of a game

Please have in mind, that drawing pairs(at least in the current release) doesn't care whether players have played with each other before so it's possible, that you'll get the same pair twice.

Adding a result of a game is pretty simple - just click on **Dodaj wynik** - it'll display a window where you can select players and enter points. The application will independently determine who won, who lost or whether it was a draw. 

**Please note that it's still a beta version so any help - posting bugs, ideas or fixes - is much appreciated!**
