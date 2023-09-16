using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMovement : MonoBehaviour
{
    public Transform playerTarget;
    public Transform mirror;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camVec = playerTarget.position - mirror.position;
        transform.localPosition = -1 * camVec;
        transform.LookAt(mirror);
    }
}
