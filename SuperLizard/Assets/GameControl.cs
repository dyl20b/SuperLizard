using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static int health, count;
    public GameObject heart1, heart2, heart3;
    public void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        count = 0;
    }
    public void Update()
    {
        if (health > 3)
        {
            health = 3;
        }
        switch (health)
        {
            case 3:
                if (count == 0)
                {
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(true);
                    count++;
                }
                break;
            case 2:
                if (count == 1)
                {
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(true);
                    heart3.gameObject.SetActive(false);
                    count++;
                }
                break;
            case 1:
                if (count == 2)
                {
                    heart1.gameObject.SetActive(true);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    count++;
                }
                break;
            case 0:
                if (count == 3)
                {
                    count++;
                    heart1.gameObject.SetActive(false);
                    heart2.gameObject.SetActive(false);
                    heart3.gameObject.SetActive(false);
                    Debug.Log("GAME OVER");
                    SceneManager.LoadScene(2);
                }
                break;
        }
    }
    public void ResetGame()
    {
        ScoreScript.CurrentScore = 0;
        SceneManager.LoadScene(1);
    }
}
