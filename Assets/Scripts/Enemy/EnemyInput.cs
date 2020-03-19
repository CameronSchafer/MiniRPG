using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    private IEnemy iEnemy;
    private float rangeFromPlayer;

    void OnEnable()
    {
        iEnemy = GetComponent<Enemy>().iEnemy;
    }

    void Update()
    {
        // if not attacking player then check if move or attack. otherwise finish the attack
        if(!iEnemy.attackPlayer)
        {
            rangeFromPlayer = Vector3.Distance(iEnemy.player.transform.position, transform.position);
            if(rangeFromPlayer <= iEnemy.attackPlayerDistance)
            {
                iEnemy.SetMoveToPlayer(false);
                iEnemy.SetAttackPlayer(true);
            }
            else if(rangeFromPlayer <= iEnemy.playerDetectionDistance)
            {
                iEnemy.SetMoveToPlayer(true);
            }
            else
            {
                iEnemy.SetMoveToPlayer(false);
            }
        }
    }
}
