using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyHydrogen : MonoBehaviour
{
    public GameObject water;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Oxygen")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(water, new Vector3(-20, 1, 0), Quaternion.identity);
        }
    }
}