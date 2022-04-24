using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static int health = 3, count = 0;
    public GameObject[] hearts;

    public void Awake()
    {
        UpdateHearts();
    }

    public void UpdateHearts()
    {
        for(int h=0; h < hearts.Length; h++)
        {
            hearts[h].gameObject.SetActive(health > h);
        }
    }

    public void Update()
    {
        if (health > 3)
        {
            health = 3;
        }
        UpdateHearts();
        if(health == 0 && count == 0)
        {
            count = 1;
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(2);
        }
    }
    public void ResetGame()
    {
        ScoreScript.CurrentScore = 0;
        health = 3;
        count = 0;
        SceneManager.LoadScene(1);
    }
}
