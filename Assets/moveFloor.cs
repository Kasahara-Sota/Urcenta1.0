using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public float width = 1f;
    public float height = 1f;
    public float speed = 1f;
    Vector2 _initialPosition;
    void Start()
    {
        _initialPosition = transform.position;
    }
    void FixedUpdate()
    {
        float x = width * Mathf.Cos(speed * Time.timeSinceLevelLoad);
        float y = height * Mathf.Sin(speed * Time.timeSinceLevelLoad);
        Vector2 pos = transform.position;
        pos.x += x;
        pos.y += y;
        transform.position = pos;
    }

    // Start is called before the first frame update
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
