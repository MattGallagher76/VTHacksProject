using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackToHeadset : MonoBehaviour
{
    public Transform headset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = new Vector3(0f, headset.localEulerAngles.y, 0f);
        transform.localEulerAngles = temp;
    }
}
