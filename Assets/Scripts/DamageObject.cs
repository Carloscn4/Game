using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
