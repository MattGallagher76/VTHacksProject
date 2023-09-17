using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Android;

[System.Serializable]
public class MapTransforms{

    public Transform vrTarget;
    public Transform ikTarget;

    public Vector3 trackingPositionOffset;
    public Vector3 trackingRotationOffset;

    public void VRMapping(int id){
        ikTarget.position = vrTarget.TransformPoint(trackingPositionOffset);
        if (id == 0)
            ikTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotationOffset);
        else if (id == 1)
        {
            Vector3 temp = new Vector3(trackingRotationOffset.x, trackingRotationOffset.y + 90f, trackingRotationOffset.z);
            ikTarget.rotation = vrTarget.rotation * Quaternion.Euler(temp);
        }
        else if (id == 2)
        {
            Vector3 temp = new Vector3(trackingRotationOffset.x + 180f, trackingRotationOffset.y + 90f, trackingRotationOffset.z);
            ikTarget.rotation = vrTarget.rotation * Quaternion.Euler(temp);
        }
    }

}







public class AvatarController : MonoBehaviour
{

    [SerializeField] private MapTransforms head;
    [SerializeField] private MapTransforms leftHand;
    [SerializeField] private MapTransforms rightHand;

    [SerializeField] private float turnSmoothness;
    [SerializeField] Transform ikHead;
    [SerializeField] Vector3 headBodyOffset;

    [SerializeField] private int counter = 0;
    [SerializeField] private float offset = 0f;



    private void LateUpdate(){

        transform.position = ikHead.position + headBodyOffset;
        transform.forward = Vector3.Lerp(transform.forward, Vector3.ProjectOnPlane(ikHead.forward, Vector3.up).normalized, Time.deltaTime * turnSmoothness);

        counter++;
        if (counter % 100 == 0)
            offset+=5;

        head.VRMapping(0);
        leftHand.VRMapping(2);
        rightHand.VRMapping(1);

    }

}
