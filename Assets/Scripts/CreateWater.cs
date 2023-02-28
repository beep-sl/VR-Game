using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWater : MonoBehaviour
{

    public GameObject targetObject;
    void Start()
    {
       targetObject.SetActive(false);
    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "Hydrogen")
        {
            targetObject.SetActive(true);
        }

    }

}
