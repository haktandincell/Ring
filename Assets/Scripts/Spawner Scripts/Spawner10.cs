using UnityEngine;

public class Spawner10 : MonoBehaviour
{
    public GameObject arabaPrefab;
    public Sprite[] arabaSpritelari;
    public float spawnZamani = 1.5f;

    private float[] seritler = new float[] { 0.11f, -2.07f };

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

        float rastgeleX = Random.Range(-380f, -444f);
        int seritIndex = Random.Range(0, seritler.Length);
        float secilenY = seritler[seritIndex];
        Vector3 pozisyon = new Vector3(rastgeleX, secilenY, 0f);

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
