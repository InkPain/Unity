using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorerLose : MonoBehaviour
{
    Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        ScoreText.text = "You Score: " + ScoreUI.scoreAmout;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
