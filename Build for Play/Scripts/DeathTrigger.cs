using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Ball"){
            Destroy(other.gameObject);
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(2);
        }
    }
}
