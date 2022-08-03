using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;
    //public void cameraAxisX=0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;
      //  Quaternion newRotation = Quaternion.Euler(0, cameraAxisX * 0.1f, 0);
       // transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);

    }
}
