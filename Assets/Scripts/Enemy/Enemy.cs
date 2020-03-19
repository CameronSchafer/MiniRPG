using UnityEngine;

public class Enemy : MonoBehaviour
{
    public IEnemy iEnemy { get; private set; }

    private EnemyMovement enemyMovementScript;
    private EnemyInput enemyInputScript;
    private EnemyAttack enemyAttackScript;

    private float movementSpeed = 150.0f;
    private float playerDetectionDistance = 2.5f;
    private float attackPlayerDistance = 1.0f;
    private float attackTimer = 1.0f;

    void Awake()
    {
        iEnemy = new EnemyController();
        iEnemy.SetPlayerGameObject(GameObject.Find("Player"));
        iEnemy.SetRigidbody2D(GetComponent<Rigidbody2D>());
        iEnemy.SetMovementSpeed(movementSpeed);
        iEnemy.SetPlayerDetectionDistance(playerDetectionDistance);
        iEnemy.SetAttackPlayerDistance(attackPlayerDistance);
        iEnemy.SetAttackTimer(attackTimer);
        iEnemy.SetAttackLine(gameObject.transform.Find("AttackLine").gameObject);

        enemyMovementScript = GetComponent<EnemyMovement>();
        enemyInputScript = GetComponent<EnemyInput>();
        enemyAttackScript = GetComponent<EnemyAttack>();

        enemyMovementScript.enabled = true;
        enemyInputScript.enabled = true;
        enemyAttackScript.enabled = true;
    }
}
