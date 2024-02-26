using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float shotVelocity = 4f;

    private void Start()
    {
        StartCoroutine(LifeSpan());
    }

    private void Update()
    {
        transform.Translate(Vector3.right * shotVelocity * Time.deltaTime);
    }

    private IEnumerator LifeSpan()
    {
        yield return new WaitForSeconds(1.15f);
        Destroy(this.gameObject);
    }
}