using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player;
    public float yOffSet;

    void Update()
    {
        transform.position = new Vector3(
            player.transform.position.x, 
            player.transform.position.y + yOffSet, 
            transform.position.z);
    }
}
