using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMove : MonoBehaviour
{ 
    public float speed = 10;
     float speedTurn = 40;
    public float speedHorizontal;
    public float speedVertical;
    void Start()
    {
        
    }

   
    void Update()
    {
        speedHorizontal = Input.GetAxis("Horizontal");
        speedVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * speedVertical);
        transform.Rotate(Vector3.up * Time.deltaTime * speedTurn * speedHorizontal);
    }
}
