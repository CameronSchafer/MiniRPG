using UnityEngine;

public class Player : MonoBehaviour
{
    public IPlayer iPlayer { get; private set; }
    private PlayerMovement playerMovementScript;
    private PlayerInput playerInputScript;
    private PlayerTriggerManager playerTriggerManagerScript;

    private float movementSpeed = 200.0f;

    void Awake() 
    {
        // will pull in details/stats from a game state manager after save file read

        // set up the interface variables
        iPlayer = new PlayerController();
        iPlayer.SetRigidbody2D(GetComponent<Rigidbody2D>());
        iPlayer.SetMovementSpeed(movementSpeed);
        iPlayer.SetMovementDirection(new float[2]);

        // retrieve other scripts to enable.
        playerMovementScript = GetComponent<PlayerMovement>();
        playerInputScript = GetComponent<PlayerInput>();
        playerTriggerManagerScript = GetComponent<PlayerTriggerManager>();

        // enable scripts once setup is complete
        playerMovementScript.enabled = true;
        playerInputScript.enabled = true;
        playerTriggerManagerScript.enabled = true;
    }
}
