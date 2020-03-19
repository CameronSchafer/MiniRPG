using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private IEnemy iEnemy;

    void OnEnable()
    {
        iEnemy = GetComponent<Enemy>().iEnemy;
    }

    void FixedUpdate()
    {
        if(iEnemy.moveToPlayer)
        {
            Vector2 movementVector = iEnemy.player.transform.position - transform.position;
            movementVector = movementVector.normalized * iEnemy.movementSpeed * Time.deltaTime;
            iEnemy.rb2D.velocity = movementVector;
        }
        else
        {
            iEnemy.rb2D.velocity = Vector2.zero;
        }
    }
}
