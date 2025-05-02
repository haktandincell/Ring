using UnityEngine;

public class RandomCarSpawner : MonoBehaviour
{
    public GameObject arabaPrefab;
    public Sprite[] arabaSpritelari;

    public float spawnZamani = 1.5f;
    

    // �eritlerin X koordinatlar�
    private float[] seritler  = new float[] { 10.35f, 12.78f };

    void Start()
    {
        InvokeRepeating(nameof(ArabaSpawnla), 1f, spawnZamani);
    }

    void ArabaSpawnla()
    {
        
        float RastgeleX = Random.Range(-453f, -380f);

        // Rastgele bir �erit se� (0 ya da 1)
        int seritIndex = Random.Range(0, seritler.Length);
        float secilenY = seritler[seritIndex];
        Vector3 pozisyon = new Vector3(RastgeleX, secilenY, 0f);

        // Arabay� olu�tur
        GameObject yeniAraba = Instantiate(arabaPrefab, pozisyon, Quaternion.Euler(0f,0f,270f));

        // Sprite'� rastgele de�i�tir
        SpriteRenderer sr = yeniAraba.GetComponent<SpriteRenderer>();
        if (sr != null && arabaSpritelari.Length > 0)
        {
            Sprite rastgeleSprite = arabaSpritelari[Random.Range(0, arabaSpritelari.Length)];
            sr.sprite = rastgeleSprite;
        }
    }
}
