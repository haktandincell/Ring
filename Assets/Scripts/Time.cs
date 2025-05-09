using UnityEngine;
using TMPro; // TextMeshPro kullan�yorsan
using UnityEngine.SceneManagement; 

public class Times : MonoBehaviour
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
            kalanSure -= Time.deltaTime;

            if (kalanSure <= 0)
            {
                kalanSure = 0;
                sayacAktif = false;
                SceneManager.LoadScene(2); // GameOver sahnesine ge�i� yap

            }
            zamanText.text = "Kalan S�re: "+Mathf.CeilToInt(kalanSure).ToString();
        }
    }
}
