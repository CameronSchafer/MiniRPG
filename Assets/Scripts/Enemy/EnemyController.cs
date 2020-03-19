using UnityEngine;

public class EnemyController : IEnemy
{
    public void SetPlayerGameObject(GameObject playerObject)
    {
        player = playerObject;
    }

    public void SetRigidbody2D(Rigidbody2D rigidbody2D)
    {
        rb2D = rigidbody2D;
    }
    
    public void SetMovementSpeed(float movespeed)
    {
        movementSpeed = movespeed;
    }
    
    public void SetMoveToPlayer(bool m2p)
    {
        moveToPlayer = m2p;
    }
    
    public void SetAttackPlayer(bool attack)
    {
        attackPlayer = attack;
    }

    public void SetPlayerDetectionDistance(float distance)
    {
        playerDetectionDistance = distance;
    }

    public void SetAttackPlayerDistance(float distance)
    {
        attackPlayerDistance = distance;
    }

    public void SetAttackTimer(float timer)
    {
        attackTimer = timer;
    }

    public void SetAttackLine(GameObject line)
    {
        attackLine = line;
        attackLine.SetActive(false);
    }

    public GameObject player { get; private set; }
    public Rigidbody2D rb2D { get; private set; }
    public float movementSpeed { get; private set; }
    public bool moveToPlayer { get; private set; }
    public bool attackPlayer { get; private set; }
    public float playerDetectionDistance { get; private set; }
    public float attackPlayerDistance { get; private set; }
    public float attackTimer { get; private set; }
    public GameObject attackLine { get; private set; }
}
