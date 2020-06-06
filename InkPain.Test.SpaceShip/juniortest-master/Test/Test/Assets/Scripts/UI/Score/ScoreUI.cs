using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public static int scoreAmout;
    Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        scoreAmout = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + scoreAmout;
    }
}
