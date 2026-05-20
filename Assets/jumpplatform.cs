using UnityEngine;

public class jumpplatform : MonoBehaviour
{
    public float jumpforce = 30;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * jumpforce , ForceMode2D.Impulse);
    }
}
