using UnityEngine;

public class PlatformTakibi : MonoBehaviour
{
    [SerializeField]
    private Vector3 hiz; // Platformun hareket yönü ve hızı
    private bool hareketDurum; // Platformun hareket edip etmediğini kontrol eden değişken

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") // Çarpışan nesne "Player" tag'ine sahipse
        {
            hareketDurum = true; // Platform hareket etmeye başlar
            coll.gameObject.transform.SetParent(transform); // Oyuncu platforma bağlı hale gelir
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") // Çarpışan nesne "Player" tag'ine sahipse
        {
            hareketDurum = false; // Platform hareketi durur
            coll.gameObject.transform.SetParent(null); // Oyuncu platformdan ayrılır
        }
    }

    private void FixedUpdate()
    {
        if (hareketDurum) // Eğer hareket durumu aktifse
        {
            transform.position += hiz * Time.deltaTime; // Platform belirtilen hızda hareket eder
        }
    }
}

