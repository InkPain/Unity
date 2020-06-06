using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Lose : MonoBehaviour
{
    HPSystem healthSystem;

    public GameObject LoseMenueUI;

    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("Player").GetComponent<HPSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSystem.health == 0)
        {
            LoseMenue();
        }
    }

    public void RestartGame()
    {
        LoseMenueUI.SetActive(false);
        SceneManager.LoadScene(0);
    }
    void LoseMenue()
    {
        LoseMenueUI.SetActive(true);
        Destroy(GameObject.FindWithTag("Player"));
        //Destroy(GameObject.FindWithTag("ScoreText"));
        //Destroy(GameObject.FindWithTag("HPUI"));
    }
}
