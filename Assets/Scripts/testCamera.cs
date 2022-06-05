using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCamera : MonoBehaviour
{
    public GameObject player; 
    Vector3 offset = new Vector3(0,5,-7);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
