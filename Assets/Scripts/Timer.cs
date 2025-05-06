using UnityEngine;
using TMPro; // TextMeshPro kullanýyorsan

public class Zamanlayici : MonoBehaviour
{
    public float toplamSure = 10f;
    public TextMeshProUGUI zamanText; // Eðer normal Text kullanýyorsan Text kullan

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
            zamanText.text = "Kalan Süre: ";
            kalanSure -= Time.deltaTime;

            if (kalanSure <= 0)
            {
                kalanSure = 0;
                sayacAktif = false;
                // Burada süre bitince yapýlacak iþlemi yaz (mesela oyun bitir)
            }

            zamanText.text += Mathf.CeilToInt(kalanSure).ToString();
        }
    }
}
