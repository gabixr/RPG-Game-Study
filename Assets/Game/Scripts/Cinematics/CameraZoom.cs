using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] float maxCameraDistance;
    float cameraDistance;
    [SerializeField] float sensitivity = 10f;
    CinemachineComponentBase componentBase;

    private void Update()
    {
        if (componentBase == null)
        {
            componentBase = virtualCamera.GetCinemachineComponent(CinemachineCore.Stage.Body);
            maxCameraDistance = (componentBase as CinemachineFramingTransposer).m_CameraDistance;
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            cameraDistance = Input.GetAxis("Mouse ScrollWheel") * sensitivity;

            if (componentBase is CinemachineFramingTransposer)
            {
                if (cameraDistance < 0)
                {
                    (componentBase as CinemachineFramingTransposer).m_CameraDistance -= cameraDistance;
                    if ((componentBase as CinemachineFramingTransposer).m_CameraDistance > maxCameraDistance)
                    {
                        (componentBase as CinemachineFramingTransposer).m_CameraDistance = maxCameraDistance;
                    }
                }
                else
                {
                    (componentBase as CinemachineFramingTransposer).m_CameraDistance -= cameraDistance;
                    if ((componentBase as CinemachineFramingTransposer).m_CameraDistance < 2)
                    {
                        (componentBase as CinemachineFramingTransposer).m_CameraDistance = 2;
                    }
                }
            }

        }
    }
}