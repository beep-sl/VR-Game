using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    void Start() {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0,2,4);
        //transform.rotation = Quaternion.Lerp(toRotate.transform.rotation, GetComponent<Camera>().transform.rotation, 100 * Time.deltaTime);

    }
}
