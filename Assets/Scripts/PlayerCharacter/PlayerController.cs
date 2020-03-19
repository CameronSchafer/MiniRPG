using UnityEngine;

public class PlayerController : IPlayer
{
    public void SetRigidbody2D(Rigidbody2D rigidbody2D)
    {
        rb2D = rigidbody2D;
    }
    
    public void SetMovementSpeed(float movespeed)
    {
        movementSpeed = movespeed;
    }
    
    public void SetMovePlayer(bool toMovePlayer)
    {
        movePlayer = toMovePlayer;
    }

    public void SetMovementDirection(float[] direction)
    {
        movementDirection = new float[2] {direction[0], direction[1]};
    }

    public Rigidbody2D rb2D { get; private set; }
    public float movementSpeed { get; private set; }
    public bool movePlayer { get; private set; }
    public float[] movementDirection { get; private set; }
}
