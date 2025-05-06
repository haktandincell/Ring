using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Araban�n Transform'u
    public Vector3 offset = new Vector3(2f, 1f, -10f); // Sa�dan ve yukar�dan hafif bak��
    public float smoothSpeed = 5f;

    private Vector3 currentVelocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        // Araban�n localScale.x'ine g�re offset'i tersle
        float direction = Mathf.Sign(target.localScale.x);
        Vector3 dynamicOffset = new Vector3(offset.x * direction, offset.y, offset.z);

        // Hedef pozisyonu hesapla
        Vector3 desiredPosition = target.position + dynamicOffset;

        // Kamera pozisyonunu yumu�ak bir �ekilde hedefe yakla�t�r
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, 1f / smoothSpeed);

        // Kamera rotasyonunu hedefin y�n�ne bakacak �ekilde ayarla (2D i�in gerekmeyebilir ama olas� rotasyonlar� s�f�rlamak i�in)
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
