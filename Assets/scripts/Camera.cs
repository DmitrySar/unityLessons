using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float speed = 3f;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
        Vector3 position = target.transform.position;
        transform.position = new Vector3(position.x, position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = target.position;
        position.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
    }
}
