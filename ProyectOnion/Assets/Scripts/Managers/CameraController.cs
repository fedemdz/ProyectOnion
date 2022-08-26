using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject[] camera;
    private int cam = 2;
    // Start is called before the first frame update
    void Start()
    {
        cam++;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (cam > 3)
            {
                cam = 1;
            }
            if (cam == 1)
            {
                Camera1();
            }
            if (cam == 2)
            {
                Camera2();
            }
            if (cam == 3)
            {
                Camera3();
            }
            cam++;
        }
    }
    private void Camera1()
    {
        camera[0].SetActive(true);
        camera[1].SetActive(false);
        camera[2].SetActive(false);
    }
    private void Camera2()
    {
        camera[0].SetActive(false);
        camera[1].SetActive(true);
        camera[2].SetActive(false);
    }
    private void Camera3()
    {
        camera[0].SetActive(false);
        camera[1].SetActive(false);
        camera[2].SetActive(true);
    }
}
