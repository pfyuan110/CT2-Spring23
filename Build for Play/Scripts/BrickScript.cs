using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickScript : MonoBehaviour
{
    public int pointValue = 1;
    public int hitPoints = 1;
    static int numBricks = 0;

    //Instantiate Bonus
    public float Level = 0.5f;
    private float Bonus = 0.0f;
    public GameObject bonusPrefab;
    
    public GameObject gameManager;

    void Start()
    {
        numBricks ++;
    }

    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "Ball"){
            Bonus = Random.Range(0.0f,1.0f);
            Debug.Log(Bonus);
            if (Bonus >= Level){
                Instantiate(bonusPrefab, transform.position, Quaternion.Euler(0f, 0f, 38f));
            }

            hitPoints --;
            if(hitPoints <= 0){
                Die();
            }
        }
    }

    void Die(){
        Destroy (gameObject);
        gameManager.GetComponent<Score>().AddPoint(pointValue);

        numBricks --;
        if(numBricks <= 0){
            Debug.Log("You are a Brick Game Master!");
            SceneManager.LoadScene(1);
        }
    }
}
