using Unity.VisualScripting;
using UnityEngine;

public class ArabaHareket : MonoBehaviour
{
    public float hiz = 5f;
    //public float[] yokOlmaX = new float[10] {-380,-287,-158,-107,4.1f,-87.4f,-138,-261,-355,-446};
    
    void Update()
    {
        transform.Translate(Vector2.up * hiz * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("destroy"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("destroy3"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 70f);
        }       
        else if (other.CompareTag("destroy4"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        else if (other.CompareTag("destroy2"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 120f);
        }
        else if (other.CompareTag("destroy5"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 109f);
        }

        else if (other.CompareTag("destroy6"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 290);
        }

        else if (other.CompareTag("destroy7"))
        {
            transform.rotation = Quaternion.Euler(0f,0f,0f);
        }

        else if (other.CompareTag("destroy10"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 45f);
        }
        else if (other.CompareTag("destroy9"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 290f);
        }
        else if (other.CompareTag("destroy11"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 270f);
        }
        else if (other.CompareTag("destroy12"))
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 250f);
        }
    }
}
