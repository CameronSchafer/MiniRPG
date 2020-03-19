using UnityEngine;

public interface IPlayer
{
    void SetRigidbody2D(Rigidbody2D rigidbody2D);
    void SetMovementSpeed(float movespeed);
    void SetMovePlayer(bool toMovePlayer);
    void SetMovementDirection(float[] direction);

    Rigidbody2D rb2D { get; }
    float movementSpeed { get; }
    bool movePlayer { get; }
    float[] movementDirection { get; }
}
