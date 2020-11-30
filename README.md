# Brick Breaker

 ![](https://i.imgur.com/77TK9zB.png)

## Hello and welcome to our Unity based game Brick Breaker in the framwork of Game Dev!

In this game you are the breaker who should break all the bricks (of any type) with the help of our ball to complete the level.
There are 3 levels you need to complete before you can finish the game.
You have 3 strikes where you can let the ball slip out from the breaker hands like the original game.
Any brick break will earn yourself 1 point and there are no time limit on any level.

###Elements

We have 3 types of Bricks:

Normal brick: ![](https://i.imgur.com/JHqhRzz.png) - this brick would break after 1 hit.

Ill brick: ![](https://i.imgur.com/HzqBSvi.png) - this brick would break after 2 hit, it will be turn greener after 1 hit.

Hard brick: ![](https://i.imgur.com/CkcfZhv.png) - this brick would break after 3 hit, it will be turn greener after 1 hit.

We have the ball which uses Ball-[Physics Material 2D](https://docs.unity3d.com/Manual/class-PhysicsMaterial2D.html) on [RigidBody2D](https://docs.unity3d.com/Manual/class-Rigidbody2D.html) and [CircleCollider2D](https://docs.unity3d.com/ScriptReference/CircleCollider2D.html) for Physics impacts - ![](https://i.imgur.com/EvFo6BG.png)

We also have the breaker(paddle) ![](https://i.imgur.com/SXKxjdx.png) which uses [Polygon Collider 2D](https://docs.unity3d.com/ScriptReference/PolygonCollider2D.html)

And finally another Toggle button for audio-source to Pause/Play - ![](https://i.imgur.com/liU48mA.png)
