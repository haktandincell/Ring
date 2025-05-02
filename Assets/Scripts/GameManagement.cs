using UnityEngine;

public class GameManagement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("finish"))
        {
            Debug.Log("Bitiþ çizgisine ulaþýldý!");
         
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            Debug.Log("Araba ile çarpýþýldý!");
            // Burada çarpýþma sonrasý yapýlacak iþlemleri ekleyebilirsiniz.
        }
    }


}
