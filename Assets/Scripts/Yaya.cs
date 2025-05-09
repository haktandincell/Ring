using UnityEngine;

public class Yaya : MonoBehaviour
{
    public int hiz = 5;
    
    private void Update()
    {
        transform.Translate(Vector2.down * hiz * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("yayaGecti"))
        {

            Debug.Log("Çaptý");
            hiz = 0;

        }
    }
}
