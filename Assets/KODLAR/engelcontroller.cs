using UnityEngine;

public class engelcontroller : MonoBehaviour
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
}
