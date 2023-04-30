using System;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public static Action OnColided { get; set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
        {
            return;
        }

        OnColided?.Invoke();
    }
}
