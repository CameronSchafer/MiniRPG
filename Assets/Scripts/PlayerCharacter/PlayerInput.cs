using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private IPlayer iPlayer;

    void OnEnable()
    {
        iPlayer = GetComponent<Player>().iPlayer;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal != 0 || vertical != 0)
        {
            iPlayer.SetMovePlayer(true);
            iPlayer.SetMovementDirection(new float[2] {horizontal, vertical});
        }
        else 
        {
            iPlayer.SetMovePlayer(false);
        }
    }
}
