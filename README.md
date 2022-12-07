# Y3S1-Game Engine Design Final

Nathan Tyborski - 100781410
<br><br><br><br>
how object pooling was implemented: Object pooling was implemented by creating a list of objects which in this case is the bird object. On start we create 20 birds or whatever desired amount, it will go through a for loop, instantsiating 20 birds and adding them to the list. Whenever a bird is needed it will find the first unused bird in the list and then return its game object. If there are no available birds then it will create a new one and add it to the list then return that newly created one.
<br><br>
unity profiler: 

With pooling
![image](https://user-images.githubusercontent.com/46547981/206279973-766fc273-18f6-4006-b110-c0e466fdbdb4.png)

Without pooling
![image](https://user-images.githubusercontent.com/46547981/206280285-114c04cd-4133-4e0a-864c-bd3240e22c28.png)

<br><br>
How it optimizes the scene: As you can see with the two screenshots the one without pooling starts off slightly better, it contains lag spikes throughout the game whenever it spawns a new bird. It doesn't seem too much of an impact in these screenshots but thats only because its a very small amount of birds. Object pooling because essential when it comes to bigger, bullet hell-like or similar games with many objects on the screen at once.

<br><br>
How command design pattern was implemented, how it works, how it benifits: The command design pattern was implemented by creating an abstract class which all actions inherit from, they all contain an execute function. Since the execute function is in the abstract class it doesn't matter which child is active and they can easily be swapped out. The game benefits from this by allowing the player/developer to modify keybinds so then the player isn't stuck to a certain layout.

<br><br>

Implement a game management system of your choice: I would add a new score system since the one I implemented isn't based off of time the player can't lose. I would implement this system using a singleton so then any object such as the bird that requires the score can access it easily. The game benefits from this by allowing the code to be cleaner and more efficent by only having one object of each class.
