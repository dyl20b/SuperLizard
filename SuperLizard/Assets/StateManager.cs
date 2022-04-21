using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateManager : MonoBehaviour
{
    public void ReloadScene()
    {
        ScoreScript.CurrentScore = 0;
        SceneManager.LoadScene(0);
    }
}
