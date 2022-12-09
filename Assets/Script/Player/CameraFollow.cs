using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject Player;
    public Transform target;
    public Vector3 offset;
  
    void Start ()
    {
        // target = player.transform;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
        transform.LookAt(target);
    }
}
