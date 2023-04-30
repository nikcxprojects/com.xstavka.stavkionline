using UnityEngine;

public class GreenLine : MonoBehaviour
{
    private void Start()
    {
        var x = Random.Range(-1.5f, 1.5f);
        var position = new Vector2(x, transform.position.y);
        transform.localPosition = position;
    }
}
