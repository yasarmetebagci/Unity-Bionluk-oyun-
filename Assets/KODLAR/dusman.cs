using UnityEngine;

public class dusman : MonoBehaviour
{
    public float hiz = 3f;
    private GameObject karakter;

    private void Start()
    {
        karakter = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        HedefeDogruGit();
    }

    private void HedefeDogruGit()
    {
        if (karakter != null)
        {
            Vector3 hareketYonu = (karakter.transform.position - transform.position).normalized;
            transform.Translate(hareketYonu * hiz * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mermi"))
        {
            Destroy(gameObject);
        }
    }
}
