using UnityEngine;
using UnityEngine.SceneManagement;


public class LizardScript : MonoBehaviour
{
    Vector3 originalPos;
    public Rigidbody2D rb;

    private void Start()
    {
        originalPos = gameObject.transform.position;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (rb.position.x < 6)
                rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (rb.position.x > -6)
                rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (rb.position.y < 8)
                rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (rb.position.y > -4)
                rb.MovePosition(rb.position + Vector2.down);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Car")
        {
            GameControl.health -= 1;
            gameObject.transform.position = originalPos;
        }
        if (collision.tag == "Bug")
        {
            Debug.Log("Yummy Grub!");
            ScoreScript.CurrentScore += 10;
            Destroy(collision.gameObject);
        }
    }

}

