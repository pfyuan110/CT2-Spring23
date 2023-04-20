using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PaddleMovement : MonoBehaviour
{
    //keyboard
    public float Move = 0.1f;
    
    //Arduino
    public float addMove = 0.05f;
    public GameObject gameManager;
    private float Force = 0;

    private void FixedUpdate() 
    {
        //Arduino
        Force = addMove * gameManager.GetComponent<InputData>().dis;
        transform.Translate(Force, 0, 0);

        //keyboard
        if (Input.GetAxis("Horizontal") > 0){
            transform.Translate(Move, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") < 0 ){
            transform.Translate(-Move, 0, 0);
        }


        if (transform.position.x >= 3.85){
            transform.position = new Vector3(3.85f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -3.85){
            transform.position = new Vector3(-3.85f, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.transform.tag == "Bonus"){
            Destroy (other.gameObject);
            gameManager.GetComponent<Score>().AddPoint(2);
        }
    }
}
