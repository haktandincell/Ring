using UnityEngine;
using TMPro; // TextMeshPro kullan�yorsan

public class Zamanlayici : MonoBehaviour
{
    public float toplamSure = 10f;
    public TextMeshProUGUI zamanText; // E�er normal Text kullan�yorsan Text kullan

    private float kalanSure;
    private bool sayacAktif = true;

    void Start()
    {
        kalanSure = toplamSure;
    }

    void Update()
    {
        if (sayacAktif)
        {
            zamanText.text = "Kalan S�re: ";
            kalanSure -= Time.deltaTime;

            if (kalanSure <= 0)
            {
                kalanSure = 0;
                sayacAktif = false;
                // Burada s�re bitince yap�lacak i�lemi yaz (mesela oyun bitir)
            }

            zamanText.text += Mathf.CeilToInt(kalanSure).ToString();
        }
    }
}
