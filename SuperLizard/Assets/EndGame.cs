using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Lizard")
        {
            Debug.Log("WINNER");
            ScoreScript.CurrentScore += 100;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
