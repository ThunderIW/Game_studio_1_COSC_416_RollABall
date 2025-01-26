# Roll-A-Ball Project


## Features Implemented

### 1. Ball Movement
- **Control Scheme:** The ball's movement is controlled using the `W`, `A`, `S`, and `D` keys for directional control.
- **Physics Integration:** Movement is implemented using Unity's `Rigidbody` component, which applies forces to simulate realistic physics.

### 2. Ball Jump
- **Jump Mechanic:** Pressing the `Space` key allows the ball to jump.
- **Collision Detection:** A collision system was added to ensure the ball can only jump when in contact with the ground using
- achieve by using the builtin collision function and setting the gameObject to "BottomOfBox"
```csharp
  void OnCollisionEnter(Collision collision)
  {
      if (collision.gameObject.name == "bottomOfBox")
      {
          isGrounded=true;
          // Allow the ball to jump
      }
  }

```

### 3. Physics Materials
- **Bounce Simulation:** A physics material was added to the ball to simulate realistic bounces.
- **Friction Adjustment:** Friction was fine-tuned to ensure smooth and controlled interactions with the environment.

### 4. Environment Setup
- Added walls around the plane to prevent the ball from falling off the edges.
- Applied materials to the ball and the environment for improved visuals.

### 5. Video demo
Here is the game in action 
[![Watch the video](https://img.youtube.com/vi/U1zhfmVnp5E/maxresdefault.jpg)](https://youtu.be/U1zhfmVnp5E)
[Click here to watch the full video](https://youtu.be/U1zhfmVnp5E)




