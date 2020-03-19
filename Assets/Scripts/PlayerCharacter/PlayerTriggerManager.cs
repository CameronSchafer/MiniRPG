using UnityEngine;

public class PlayerTriggerManager : MonoBehaviour
{
    private IPlayer iPlayer;

    void OnEnable()
    {
        iPlayer = GetComponent<Player>().iPlayer;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    }
}
