README.md - THE GAME

Description

This repo contains a simple implementation of The Game (a collaborative card game) written in Unity. Our version is a single player drag-and-drop card game where the goal is to stack as many cards as possible into either two ascending, or descending piles.

Division of Labor

Jiyun:
	created the skeleton of the Unity game using the excellent UFO Game tutorial (linked below) as a reference
	implemented the click and drag functionality of the cards.
	made randomized shuffle function for random int to be generated from deck of cards

Stephanie
	created the art assets for each individual card
	implemented visibility function of cards to be used in conjunction with the shuffle function
	implemented “snapping” feature so that cards are neatly sorted into groups
	
What we learned
	We both learned some basic C# and used Unity for the first time. We took advantage of Prefabs for card generation, some very basic vector transformation, and some of the lifecycle events for Unity objects.
	
What didn't work
	We originally planned to make a multiplayer game complete with sounds, animations, and other bells and whistles. Unfortunately, we didn’t have nearly enough time for these features. We also decided to scrap the idea of messing with layer sorting for the cards, and enforcing rules on which cards can legally go on which stack. These are all problems that we would tackle given more time.

References:
https://unity3d.com/learn/tutorials/projects/2d-ufo-tutorial
