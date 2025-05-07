using UnityEngine;

public class ArabaHareket : MonoBehaviour
{
    public float hiz = 5f;
    public float yokOlmaX = -380f;

    void Update()
    {
        transform.Translate(Vector2.up * hiz * Time.deltaTime);

        if (transform.position.x > yokOlmaX)
        {
            Destroy(gameObject);
        }
    }
}
