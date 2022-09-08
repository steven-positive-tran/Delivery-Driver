using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] 
    GameObject thingToFollow;
    // this things position is the same position as the car's position

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);
        
    }
}
