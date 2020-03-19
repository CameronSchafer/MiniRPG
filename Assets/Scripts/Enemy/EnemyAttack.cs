using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private IEnemy iEnemy;

    private float attackTimerCountdown;
    private Vector3 locationRelativeToPlayer;
    private SpriteRenderer attackLineSprite;
    private float attackLineRotation;

    void OnEnable()
    {
        iEnemy = GetComponent<Enemy>().iEnemy;
        attackTimerCountdown = iEnemy.attackTimer;
        attackLineSprite = iEnemy.attackLine.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(attackTimerCountdown <= 0)
        {
            iEnemy.SetAttackPlayer(false);
            iEnemy.attackLine.SetActive(false);
            attackTimerCountdown = iEnemy.attackTimer;
            iEnemy.attackLine.GetComponent<BoxCollider2D>().enabled = false;
        }
        
        if(iEnemy.attackPlayer)
        {
            if(attackTimerCountdown == iEnemy.attackTimer)
            {
                iEnemy.attackLine.SetActive(true);
                PointAttackTowardsPlayer();
            }

            BrightenAttackLine();
            
            attackTimerCountdown -= Time.deltaTime;
            // attack is active/able to hit player for a percentage of attack time remaining
            if (attackTimerCountdown <= 0)
            {
            }
        }
    }

    void BrightenAttackLine()
    {
        Color spriteColour = iEnemy.attackLine.GetComponent<SpriteRenderer>().color;
        spriteColour.a = 1 - attackTimerCountdown / iEnemy.attackTimer;
        attackLineSprite.color = spriteColour;
    }

    void PointAttackTowardsPlayer()
    {
        locationRelativeToPlayer = iEnemy.player.gameObject.transform.position - transform.position;
        locationRelativeToPlayer.Normalize();
        attackLineRotation = Mathf.Atan2(locationRelativeToPlayer.y, locationRelativeToPlayer.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(0f, 0f, attackLineRotation);
    }
}
