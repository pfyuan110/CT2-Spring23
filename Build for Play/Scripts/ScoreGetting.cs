using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGetting : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Start() {
        text.text = Score.score.ToString();
    }

    private void Update() {
        text.text = Score.score.ToString();
    }
}
