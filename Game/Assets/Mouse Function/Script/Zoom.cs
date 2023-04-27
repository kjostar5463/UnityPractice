using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;

        mainCamera.fieldOfView = Mathf.Clamp
            (
                mainCamera.fieldOfView,         // �����ϰ� ���� �Ӽ�
                20.0f,                          // �ּڰ�
                60.0f                           // �ּڰ�
            );
        mainCamera.fieldOfView += distance;
    }
}
