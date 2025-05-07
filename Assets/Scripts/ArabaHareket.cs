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
            Destroy(this.gameObject);
        }
    }
}
