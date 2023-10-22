using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{   
    public int count = 0; 
    public float moveSpeed = 10.0f;
    void Update()
    {   
        if (Input.GetKey(KeyCode.W)){
            this.transform.position += transform.up * this.moveSpeed * Time.deltaTime ;
        }
        if (Input.GetKey(KeyCode.S)){
            this.transform.position -= transform.up * this.moveSpeed * Time.deltaTime ;
        }
        if (Input.GetKey(KeyCode.A)){
            this.transform.position -= transform.right * this.moveSpeed * Time.deltaTime ;
        }if (Input.GetKey(KeyCode.D)){
            this.transform.position += transform.right * this.moveSpeed * Time.deltaTime ;

        }
    }
}
