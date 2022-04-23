using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    public void ResetGame()
    {
        ScoreScript.CurrentScore = 0;
        SceneManager.LoadScene(1);
    }
}
