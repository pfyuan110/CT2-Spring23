using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    //public TextMeshProUGUI text;

    private void Start() {
        //text.text = score.ToString();
        score = 0;
        //if(SceneManager.Equals() == 1)
    }

    private void Update() {
        //text.text = score.ToString();
    }

    public void AddPoint(int s){
        score += s;
    }
}
