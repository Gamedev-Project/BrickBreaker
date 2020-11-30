# Brick Breaker

 ![](https://i.imgur.com/77TK9zB.png)

## Hello and welcome to our Unity based game Brick Breaker in the framwork of Game Dev!

In this game you are the breaker who should break all the bricks (of any type) with the help of our ball to complete the level.
There are 3 levels you need to complete before you can finish the game.
You have 3 strikes where you can let the ball slip out from the breaker hands like the original game.
Any brick break will earn yourself 1 point and there are no time limit on any level.

## Elements

We have 3 types of Bricks which uses [Box Collider 2D](https://docs.unity3d.com/ScriptReference/BoxCollider2D.html) and [Particle System](https://docs.unity3d.com/ScriptReference/ParticleSystem.html) (existing on Ball) for scenery:

Normal brick: ![](https://i.imgur.com/JHqhRzz.png) - this brick would break after 1 hit.

Ill brick: ![](https://i.imgur.com/HzqBSvi.png) - this brick would break after 2 hit, it will be turn greener after 1 hit.

Hard brick: ![](https://i.imgur.com/CkcfZhv.png) - this brick would break after 3 hit, it will be turn greener after 1 hit.

We have the ball which uses Ball-[Physics Material 2D](https://docs.unity3d.com/Manual/class-PhysicsMaterial2D.html) on [RigidBody2D](https://docs.unity3d.com/Manual/class-Rigidbody2D.html) and [CircleCollider2D](https://docs.unity3d.com/ScriptReference/CircleCollider2D.html) for Physics impacts - ![](https://i.imgur.com/EvFo6BG.png)

We also have the breaker(paddle) ![](https://i.imgur.com/SXKxjdx.png) which uses [Polygon Collider 2D](https://docs.unity3d.com/ScriptReference/PolygonCollider2D.html)

And finally another Toggle button for audio-source to Pause/Play - ![](https://i.imgur.com/liU48mA.png)

## Scripts

We have 5 Scripts who helps operate the Brick Breaker:

### [BallScr](https://github.com/Gamedev-Project/BrickBreaker/blob/main/Assets/Scripts/BallScr.cs)
The ball script who helps the ball with its Positioning and moving. also have [OnTriggerEnter2D](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html) and [OnCollisionEnter2D](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html) which deals with tags that operate Live decrease, brick destroy, Score increase and boundries
### [BreakerMover](https://github.com/Gamedev-Project/BrickBreaker/blob/main/Assets/Scripts/BreakerMover.cs)
The Breaker (paddle) script who help with the boundries of the paddle and the Mouse movement
### [Brick Scr](https://github.com/Gamedev-Project/BrickBreaker/blob/main/Assets/Scripts/BrickScr.cs)
The Brick script who Decrese Brick Live if its a Brick with more then 1 hit to destroy and define new color after 1 hit.
### [GameStatus](https://github.com/Gamedev-Project/BrickBreaker/blob/main/Assets/Scripts/GameStatus.cs)
This Script helps with Scene Management and Configuring The info Bars (level,lives etc..)
Also its responsable for button operation like "play again" And "Game Over"
### [Rotate](https://github.com/Gamedev-Project/BrickBreaker/blob/main/Assets/Scripts/Rotate.cs)
This Script is for the Bricks Movement on level 2 and level 3 which uses Sinus function to Tilt left and right.

## Game Link
And of course, Brick Breaker is up and ready to play [Right here!](https://aviniv.itch.io/brickbreaker)

### Hope you Like it! Niv & Avi!!
