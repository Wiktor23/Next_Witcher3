using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickToPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        collision.gameObject.transform.SetParent(transform);
    }
    private void OnTriggerExit(Collider collision)
    {
            collision.gameObject.transform.SetParent(null);
    }
}
