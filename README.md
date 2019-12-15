# Unity Android Game

## Project Description
The purpose of this project is to increase understanding on how to create a playable Android game that can be played on:
 - Smart Phones
 - Tablets
 - PC (Windows and Mac)

## Expected Learning Outcomes
For this project, I have decided to cover the following areas:
- [x] Programming in C#
- [x] Using Unity
  - [x] Create a simple platformer game
    - [x] Health
    - [x] Score
    - [x] Moving enemies
    - [x] Static enemies
    - [x] Scrolling platforms
    - [x] Levels
    - [x] Boss
    - [x] Powers
    - [x] Shooting
    - [x] Sprite animation
    - [x] 3 Levels
    - [x] Audio effects
    - [x] Particles
  - [x] Game background audio
  - [ ] Screens / Scenes
    - [x] Main menu
    - [ ] Store screen (integration for inApp purchases)
    - [x] Gameplay screen
- [x] Creating game sprites
- [x] Writing automated
  - [x] Unit tests
- [ ] Integration with InApp Store purchase
- [x] Integration for Mobile Ads

Once all the above areas have been marked off, this should be enough to get started on a first possible Play Store Android project.

## User Flow
The flow diagram below details the journey that a user would take whilst navigating the game. For this game project, we should aim to do a portion of the flow: 
![User flow diagram](https://github.com/msuddin/unity-android-dino-crush/blob/master/user_flow_digram.png)

## Foot Note
This project is designed to be a learning process.
Although I will try to write clean code, use design pattern, write well maintained tests etc,
I will prioritise working application and documentation over a well polished and finished product.

## Resources
All the sprites for this game were found on:
Sprites: https://www.gameart2d.com/freebies.html

The logo for the game was generated from:
Generate Logo: https://cooltext.com/

The fonts for this game where found in:
Fonts: https://www.fontsquirrel.com/fonts/komika-axis

Bullet fire sound:
https://opengameart.org/content/37-hitspunches

Background music track from:
https://opengameart.org/content/5-chiptunes-action

## Known Bugs
 - Double jumping right under a 'ground' label platform can cause player to double jump forever
 - Double power particles appear behind the game background as well as the bullets fired (disabled background to allow bullet and particle visibility)
 - Falling animation is a little unstable
 - Sometimes a pokeball item may leave behind an invisible box that is not removed when the player collides (and sometims not) with a given pokeball

