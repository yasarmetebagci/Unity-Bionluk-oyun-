using UnityEngine;

public class coincontroller : MonoBehaviour
{
    public float hiz = 3f;
    public float yokOlmaSure = 5f;

    private void Start()
    {
        Destroy(gameObject, yokOlmaSure);
    }

    private void Update()
    {
        transform.Translate(Vector3.left * hiz * Time.deltaTime);
 
    }
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            Destroy(gameObject);
        }
    }
    


}
