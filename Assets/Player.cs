using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void jump()
    {
        //gameObject.transform.GetComponent<Rigidbody2D>().isKinematic = false;
        gameObject.transform.SetParent(null);
    }
}

