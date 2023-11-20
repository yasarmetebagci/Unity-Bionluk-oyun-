using UnityEngine;

public class AtisNoktasi : MonoBehaviour
{
    public Transform atisNoktasi;
    public GameObject mermiPrefab;
    public float atisHizi = 0.5f;

    private float sonrakiAtisZamani = 0f;
    private bool sagaBakiyor = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= sonrakiAtisZamani)
        {
            AtesEt();
            sonrakiAtisZamani = Time.time + atisHizi;
        }
    }

    private void AtesEt()
    {
        GameObject yeniMermi = Instantiate(mermiPrefab, atisNoktasi.position, atisNoktasi.rotation);

        if (!sagaBakiyor)
        {
            yeniMermi.transform.rotation *= Quaternion.Euler(0f, 180f, 0f);
        }
    }

    public void SetSagaBakiyor(bool saga)
    {
        sagaBakiyor = saga;
    }
}
