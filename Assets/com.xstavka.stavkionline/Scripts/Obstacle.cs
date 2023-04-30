using System;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public static Action OnCollided { get; set; }

    private void Start()
    {
        var z = UnityEngine.Random.Range(0.0f, 360.0f);
        transform.Rotate(Vector3.forward * z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("Player"))
        {
            return;
        }

        OnCollided?.Invoke();
    }
}
