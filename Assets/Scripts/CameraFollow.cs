using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Arabanýn Transform'u
    public Vector3 offset = new Vector3(2f, 1f, -10f); // Saðdan ve yukarýdan hafif bakýþ
    public float smoothSpeed = 5f;

    private Vector3 currentVelocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        // Arabanýn localScale.x'ine göre offset'i tersle
        float direction = Mathf.Sign(target.localScale.x);
        Vector3 dynamicOffset = new Vector3(offset.x * direction, offset.y, offset.z);

        // Hedef pozisyonu hesapla
        Vector3 desiredPosition = target.position + dynamicOffset;

        // Kamera pozisyonunu yumuþak bir þekilde hedefe yaklaþtýr
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, 1f / smoothSpeed);

        // Kamera rotasyonunu hedefin yönüne bakacak þekilde ayarla (2D için gerekmeyebilir ama olasý rotasyonlarý sýfýrlamak için)
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
