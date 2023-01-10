using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [Tooltip("Effect to play when object is collected")]
    public GameObject collectFX;

    private void OnTriggerEnter(Collider other)
    {
        if (collectFX) Instantiate(collectFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
