using UnityEngine;

public class Indicator : MonoBehaviour
{
    private float TargetX { get; set; }
    private float Speed { get; set; }

    private void Start()
    {
        Speed = Random.Range(2.0f, 8.0f);
        TargetX = Random.Range(0, 100) > 50 ? 2 : -2;
    }

    private void Update()
    {
        var target = new Vector2(TargetX, transform.position.y);
        var offset = Speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, target, offset);
        if(transform.position.x == TargetX)
        {
            TargetX *= -1;
        }
    }
}
