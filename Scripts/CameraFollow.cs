using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFollow : MonoBehaviour
{
    private Func <Vector3> GetCameraFollowPosFunc;
    public void Setup(Func<Vector3> GetCameraFollowPosFunc)
    {
        this.GetCameraFollowPosFunc = GetCameraFollowPosFunc;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraFollowPos = GetCameraFollowPosFunc();
        cameraFollowPos.z = transform.position.z;
        transform.position = cameraFollowPos;
    }
}
