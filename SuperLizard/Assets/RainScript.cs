using UnityEngine;

public class RainScript : MonoBehaviour
{

    public Rigidbody2D rb;

    public float speed = 1f;

    private void Start()
    {
        speed = Random.Range(2f, 4f);
    }

    // Update is called once per frame
    void FixedUpdate()
    { // Fixed for Physics
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
}
