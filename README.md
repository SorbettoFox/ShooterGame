-README-

Outlines and goals for the Scrolling Shooter Game

SPAWNING
enemies could spawn in waves periodically with an increase in number the higher the wave and/or higher the difficulty?
must spawn in a random location off screen, from all sides
move in a straight line towards the player at some speed
OPEN QUESTION: how will they despawn?
amount of enemies spawned should be limited by a constant

ENEMY BEHAVIORS
  
requires a sprite and hitbox
enemies must slowly move towards player's x/y position
some should shoot projectiles, having a different sprite to indicate this
could vary in speed or firing rate of lasers as more waves come
might spawn shield or a powerup upon being destroyed
different types of enemies would have a shield
if the player takes damage, they have a chance to drop any powerup they have
enemies can pick it up
if an enemy dies, who picked up a powerup, they have a 1/3rd chance to drop that powerup

THE PLAYER SHIP
  
has HP, possibly a shield, and a hitbox
must be able to shoot a projectile that moves in a straight line/ray
must have an indication where the lasers will fire so players can aim
aiming works by orienting spawn point of the laser to the direction the mouse is moving, slowly.
sprite could change as it gets damaged or gains powerups

POWERUPS
  
number of lasers: this powerup increases how many lasers you fire, up to 3. Shown along a perpendicular axis
super shield power up: grants invincibility for a duration (5-10 seconds)

UI
  
There needs to be a main menu before starting the game
Gives option for difficulty and closing the game
The background in-game changes based on the current wave (OR the player can upload one)
Allow the player to change the color of their ship (persisted data)
Sound muting on/off (default on): click to toggle (persisted data)
Screen shake on/off (default on): click to toggle (persisted data)
In game HUD
Current score, current health using a segmented progress bar, shields, powerups
Highscore list of the top 10, show unfilled spots as blank (using dashes or similar), background is simple
allow players to type up to X characters, press enter to confirm
buttons to: quit, return to menu, restart

MUSIC AND SFX (try opengameart.org)
  
player movement sound (from the rocket thrusters)
enemy spawns
enemy death
lasers being launched
lasers hitting a valid target
player shield break
powerups dropped
powerups acquired by the player
powerups acquired by the enemy (different sound)
multiple musical tracks that change when the wave changes
fade in and out
main menu track
game over track

FIRST GOALS
 
starting menu
enemy logic including waves
score
