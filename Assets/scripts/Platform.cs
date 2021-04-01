using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform leftPoint;
    public Transform rightPoint;
    private float speed = 2f;
    private Transform point;
    // Start is called before the first frame update
    void Start()
    {
        point = rightPoint;
    }

    // Update is called once per frame
    void Update()
    {
        float shift = speed * Time.deltaTime;
        if (transform.position.x <= leftPoint.position.x)
            point = rightPoint;
        if (transform.position.x >= rightPoint.position.x)
            point = leftPoint;
        transform.position = Vector3.MoveTowards(transform.position, point.position, shift);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
