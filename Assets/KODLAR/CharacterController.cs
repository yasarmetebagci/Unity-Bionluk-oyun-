using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float Ýlerleme = 5f;
    private bool sagaBakiyor = true;
    private AtisNoktasi atisNoktasi;
    public Joystick joystick;

    private void Start()
    {
        atisNoktasi = GetComponentInChildren<AtisNoktasi>();
    }

    private void Update()
    {
        float moveHorizontal = joystick.Horizontal;
        float moveVertical = joystick.Vertical;

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f) * Ýlerleme * Time.deltaTime;
        transform.position += movement;

        if (moveHorizontal > 0 && !sagaBakiyor)
        {
            SagaDon();
        }
        else if (moveHorizontal < 0 && sagaBakiyor)
        {
            SolaDon();
        }
    }

    private void SagaDon()
    {
        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        sagaBakiyor = true;
        atisNoktasi.SetSagaBakiyor(true);
    }

    private void SolaDon()
    {
        transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        sagaBakiyor = false;
        atisNoktasi.SetSagaBakiyor(false);
    }
}
