using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MirrorMovement : MonoBehaviour
{
    public Transform playerTarget;
    public Transform mirror;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempPos = new Vector3(mirror.transform.position.x, playerTarget.transform.position.y, mirror.transform.position.z);

        Vector3 camVec = playerTarget.position - tempPos;
        transform.localPosition = -1 * camVec;
        transform.LookAt(mirror);

        GetComponent<Camera>().nearClipPlane = camVec.magnitude + offset;
    }
}
