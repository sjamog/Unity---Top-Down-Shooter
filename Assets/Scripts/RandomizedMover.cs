using UnityEngine;
using System.Collections;

public class RandomizedMover : MonoBehaviour
{
    public float speed;
    public float angle;

    void Start()
    {
        //GetComponent<Rigidbody>().velocity = transform.forward * speed;

        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(Mathf.Max(0, transform.position.x / -3) - 2.0f , Mathf.Min(0, transform.position.x / -3) + 2.0f) * angle, 0, speed);
    }
}
