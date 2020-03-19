using UnityEngine;

public interface IEnemy
{
    void SetPlayerGameObject(GameObject playerObject);
    void SetRigidbody2D(Rigidbody2D rigidbody2D);
    void SetMovementSpeed(float movespeed);
    void SetMoveToPlayer(bool toMovePlayer);
    void SetAttackPlayer(bool attackPlayer);
    void SetPlayerDetectionDistance(float distance);
    void SetAttackPlayerDistance(float distance);
    void SetAttackTimer(float timer);
    void SetAttackLine(GameObject line);

    GameObject player { get; }
    Rigidbody2D rb2D { get; }
    float movementSpeed { get; }
    bool moveToPlayer { get; }
    bool attackPlayer { get; }
    float playerDetectionDistance { get; }
    float attackPlayerDistance { get; }
    float attackTimer { get; }
    GameObject attackLine { get; }
}
