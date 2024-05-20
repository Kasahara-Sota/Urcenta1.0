using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float width = 5f;
    public float _speed = 2f;
    Vector2 _initialPosition;

    void Start()
    {
        _initialPosition = transform.position;
    }

    void Update()
    {
        float x = width * Mathf.Cos(_speed * Time.timeSinceLevelLoad);
        Vector2 pos = transform.position;
        pos.x = x;
        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.SetParent(null);
        }
    }
}
