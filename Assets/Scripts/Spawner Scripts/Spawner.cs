using UnityEngine;

public class RandomCarSpawner : MonoBehaviour
{
    public GameObject arabaPrefab;
    public Sprite[] arabaSpritelari;
    public float spawnZamani = 1.5f;
    public float kontrolYaricapi = 0.5f; // �ak��ma kontrol yar��ap�

    private float[] seritler = new float[] { 11.68f, 13.81f };

    void Start()
    {
        InvokeRepeating(nameof(ArabaSpawnla), 1f, spawnZamani);
    }

    void ArabaSpawnla()
    {
        if (arabaPrefab == null)
        {
            Debug.LogWarning("arabaPrefab eksik, l�tfen atay�n!");
            return;
        }

        float rastgeleX = Random.Range(-453f, -380f);
        int seritIndex = Random.Range(0, seritler.Length);
        float secilenY = seritler[seritIndex];
        Vector3 pozisyon = new Vector3(rastgeleX, secilenY, 0f);
        Collider2D varOlan = Physics2D.OverlapCircle(pozisyon, kontrolYaricapi);
        if (varOlan != null)
        {
            // Orada zaten bir obje var, spawnlama
            return;
        }
        GameObject yeniAraba = Instantiate(arabaPrefab, pozisyon, Quaternion.Euler(0f, 0f, 90f));

        // Sprite de�i�tir
        SpriteRenderer sr = yeniAraba.GetComponent<SpriteRenderer>();
        if (sr != null && arabaSpritelari.Length > 0)
        {
            sr.sprite = arabaSpritelari[Random.Range(0, arabaSpritelari.Length)];
        }

        // Hareket scripti ekle (varsa atlama)
        if (yeniAraba.GetComponent<ArabaHareket>() == null)
        {
            yeniAraba.AddComponent<ArabaHareket>();
        }
    }
}