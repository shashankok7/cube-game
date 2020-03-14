using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name=="Finish")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
       
    }

}
