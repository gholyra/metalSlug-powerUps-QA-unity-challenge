using UnityEngine;

public class PowerUpSo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Player"))
        {
            Debug.Log("AAHHH");
            Destroy(this.gameObject);
        }
    }
}
