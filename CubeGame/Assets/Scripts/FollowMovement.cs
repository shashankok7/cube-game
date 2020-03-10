using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement : MonoBehaviour
{

    public Vector3 offset;
    public Transform player;

    void Update()
    {
        transform.position = player.position + offset;
        Debug.Log(player.position);
    }
}
