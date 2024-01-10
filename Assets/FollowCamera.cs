using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;


    void Start()
    {
        transform.position = objectToFollow.transform.position + new Vector3(0,0,-10);
    }

    void LateUpdate()
    {
        transform.position = objectToFollow.transform.position + new Vector3(0,0,-10);
    }
}
