using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 startInput;
    private Vector2 endInput;

    private Vector2 direction;

    [SerializeField] float speed;

    private void Start()
    {
        direction = Vector2.zero;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if(Input.GetMouseButtonUp(0))
        {
            endInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (endInput - startInput).normalized;
        }

        transform.Translate(speed * Time.deltaTime * direction);
        direction = Vector2.MoveTowards(direction, Vector2.zero, 1.5f * Time.deltaTime);
    }
}
