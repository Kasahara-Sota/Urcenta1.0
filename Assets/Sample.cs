using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Sample : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.SetParent(transform);
            if (collision.gameObject.TryGetComponent(out Rigidbody2D rb2D))
            {
                rb2D.isKinematic = true;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.SetParent(null);
            if (collision.gameObject.TryGetComponent(out Rigidbody2D rb2D))
            {
                rb2D.isKinematic = false;
            }
        }
    }
}
