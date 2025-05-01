using UnityEngine;

public class ArabaKontrol : MonoBehaviour
{
    public float ileriHiz = 10f;
    public float donusHizi = 200f;
    public float normalDrift = 0.95f;
    public float elFreniDrift = 0.6f;

    private float driftFaktoru;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.linearDamping = 1f;
    }

    void FixedUpdate()
    {
        float ileriGeri = Input.GetAxis("Vertical");   // W/S veya ?/?
        float solaSaga = Input.GetAxis("Horizontal");  // A/D veya ?/?
        bool elFreni = Input.GetKey(KeyCode.Space);    // Space tuþuna basýldý mý?

        driftFaktoru = elFreni ? elFreniDrift : normalDrift;

        // Aracý ileri veya geri it
        rb.AddForce(transform.up * ileriGeri * ileriHiz);

        // Aracý döndür
        float hareketliMi = Vector2.Dot(rb.linearVelocity, rb.transform.up);
        if (hareketliMi > 0.1f || hareketliMi < -0.1f)
        {
            rb.MoveRotation(rb.rotation - solaSaga * donusHizi * Time.fixedDeltaTime);
        }

        // Drift etkisi: yana kayan hareketi azalt
        Vector2 ileriYonu = transform.up * Vector2.Dot(rb.linearVelocity, transform.up);
        Vector2 yanalYonu = transform.right * Vector2.Dot(rb.linearVelocity, transform.right);
        rb.linearVelocity = ileriYonu + yanalYonu * driftFaktoru;
    }
}
