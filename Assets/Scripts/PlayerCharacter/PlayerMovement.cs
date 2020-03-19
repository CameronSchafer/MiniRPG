using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private IPlayer iPlayer;

    void OnEnable()
    {
        iPlayer = GetComponent<Player>().iPlayer;
    }

    void FixedUpdate()
    {
        if(iPlayer.movePlayer)
        {
            Vector2 movementVector = new Vector2(iPlayer.movementDirection[0], iPlayer.movementDirection[1]);
            movementVector = movementVector.normalized * iPlayer.movementSpeed * Time.deltaTime;
            iPlayer.rb2D.velocity = movementVector;
        }
        else
        {
            iPlayer.rb2D.velocity = Vector2.zero;
        }
    }
}
