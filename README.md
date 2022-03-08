# Unity Coding Basics Part 3 - Lifecycle Events, Instantiate, and Destroy

If you've been using Unity for a while, or are just getting started with Unity and decided it's time for you to start learning how to write code - this is the video series you need to start your programming journey!

* [Part 1](https://youtu.be/SXaa61JWLDw) - [Github Repository](https://github.com/llamacademy/unity-csharp-basics-1)
* [Part 2](https://youtu.be/MB6B9nHSrps) - [Github Repository](https://github.com/llamacademy/unity-csharp-basics-2)
* [Part 3](https://youtu.be/TD3yoFg3GVI) - You are here 🙂

In this tutorial repository (with [associated video](https://youtu.be/TD3yoFg3GVI)), aimed at absolute beginners who have very little to no coding experience whatsoever, you'll learn about some fundamentals in Unity - Lifecycle events, Instantiate, and Destroy.

By this point, you've probably already used some of these lifecycle events, but maybe didn't fully understand how they were called or _when_ they were called. In this tutorial you'll learn the order of execution of the following events, and what type of code you should generally put in those events:
* Awake
* Start
* OnEnable
* FixedUpdate
* Update

**📝📝📝YOUR HOMEWORK!📝📝📝**

Using the prefab we created and used today and at least 1 new script (maybe you need more, maybe not, you decide 😉) make it where when the user left clicks in the top 10% of the screen, a new instance of our Count Down Text prefab is spawned at that left click location. Make the Count Down Text prefab start falling towards the bottom of the screen.

The Count Down Text should be destroyed under 2 conditions:
1. If the AutoDestroyText count down has reached 0.
2. If the Count Down Text has gone off screen (fallen out of view).

Here's some key resources for you to gather input from the user:
* https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/Mouse.html
* https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.Controls.ButtonControl.html


Add a comment below with a video showing your code and the end result.

📚 Here are the resources I mentioned and/or brought up during the video 📚
* Order of Execution: https://docs.unity3d.com/Manual/ExecutionOrder.html
* GetComponent: https://docs.unity3d.com/ScriptReference/Component.GetComponent.html
* Instantiate: https://docs.unity3d.com/ScriptReference/Object.Instantiate.html
* Destroy: https://docs.unity3d.com/ScriptReference/Object.Destroy.html
* Vector3s: https://docs.unity3d.com/ScriptReference/Vector3.html
* Quaternions: https://docs.unity3d.com/ScriptReference/Quaternion.html
* Screen: https://docs.unity3d.com/ScriptReference/Screen.html
* Time: https://docs.unity3d.com/ScriptReference/Time.html

[![Youtube Tutorial](./Video%20Screenshot.png)](https://youtu.be/TD3yoFg3GVI)

## Patreon Supporters
Have you been getting value out of these tutorials? Do you believe in LlamAcademy's mission of helping everyone make their game dev dream become a reality? Consider becoming a Patreon supporter and get your name added to this list, as well as other cool perks.
Head over to https://patreon.com/llamacademy to show your support.

### Phenomenal Supporter Tier
* YOUR NAME HERE!

### Tremendous Supporter Tier
* YOUR NAME HERE!

### Awesome Supporter Tier
* Raphael
* Andrew Bowen
* Gerald Anderson
* AudemKay
* Paul Berry
* Matt Parkin
* YOUR NAME HERE!

### Supporters
* Bastian
* Trey Briggs
* YOUR NAME HERE!

## Other Projects
Interested in other AI Topics in Unity, or other tutorials on Unity in general? 

* [Check out the LlamAcademy YouTube Channel](https://youtube.com/c/LlamAcademy)!
* [Check out the LlamAcademy GitHub for more projects](https://github.com/llamacademy)

## Requirements
* Requires Unity 2020.3 LTS or higher. 