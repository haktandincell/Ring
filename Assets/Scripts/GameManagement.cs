using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{
    public Image image;

    void Start()
    {
        image.enabled = false; // Baþlangýçta resmi gizle
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
        
        if (other.CompareTag("Donus"))
        {
            image.enabled = !image.enabled;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("car"))
        {
            StartCoroutine(SahneyiGecikmeliYukle());
        }
    }

   
    IEnumerator SahneyiGecikmeliYukle()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(3);
    }

}
