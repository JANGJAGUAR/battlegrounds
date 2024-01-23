using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {   
            // Object Pool => coll.SetActive(false);???
            Destroy(coll.gameObject);
        }
    }
}
