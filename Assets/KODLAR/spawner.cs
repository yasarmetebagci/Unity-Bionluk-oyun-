using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject dusmanPrefab;
    public GameObject paraPrefab;
    public GameObject engelPrefab;

    public float dusmanSpawnHizi = 2f;
    public float digerleriSpawnHizi = 1f;

    private float sonrakiDusmanSpawnZamani = 0f;
    private float sonrakiDigleriSpawnZamani = 0f;

    private void Update()
    {
        if (Time.time >= sonrakiDusmanSpawnZamani)
        {
            Spawn(dusmanPrefab);
            sonrakiDusmanSpawnZamani = Time.time + dusmanSpawnHizi;
        }

        if (Time.time >= sonrakiDigleriSpawnZamani)
        {
            float rastgeleSayi = Random.Range(0f, 1f);
            if (rastgeleSayi < 0.5f)
            {
                Spawn(paraPrefab);
            }
            else
            {
                Spawn(engelPrefab);
            }

            sonrakiDigleriSpawnZamani = Time.time + digerleriSpawnHizi;
        }
    }

    private void Spawn(GameObject objePrefab)
    {
        float spawnX = Random.Range(13f, 15f);
        float spawnY = Random.Range(-5f, 5f);
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);
        Instantiate(objePrefab, spawnPosition, Quaternion.identity);
    }
}
