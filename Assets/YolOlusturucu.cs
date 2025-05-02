using UnityEngine;

public class YolOlusturucu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject yolPrefab; // Haz�rlad���n yol prefab�
    public int adet = 10; // Ka� par�a yol olacak
    public float yolGenislik = 1.0f; // Yol prefab�n�n geni�li�i (world unit cinsinden)
    void Start()
    {
        Vector3 baslangicKonumu = Vector3.zero;

        for (int i = 0; i < adet; i++)
        {
            GameObject yeniYol = Instantiate(yolPrefab, baslangicKonumu, Quaternion.identity);
            baslangicKonumu += new Vector3(yolGenislik, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
