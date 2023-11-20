using UnityEngine;

public class mermi : MonoBehaviour
{
    public float mermiHizi = 10f;
    public float yoketme = 2f;

    private void Start()
    {
        Destroy(gameObject, yoketme);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * mermiHizi * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dusman") || collision.CompareTag("Engel"))
        {
            Destroy(gameObject);
        }
    }
}
