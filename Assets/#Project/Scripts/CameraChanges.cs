using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanges : MonoBehaviour
{
    public float xRotation;
    public Camera cam;
    //private Vector3 rotateValue;
    //private float x;
    //private float y;
    public Transform target;

    public void Start()
    {
        Camera cam = gameObject.GetComponent<Camera>();
       
    }

    public void Update()
    {
        ChangeRotation();
    }
    private void ChangeRotation()
    {

        //y = Input.GetAxis("Mouse X");
        //x = Input.GetAxis("Mouse Y");
        //Debug.Log(x + ":" + y);
        //rotateValue = new Vector3(x*  -1, y, 0);
        //transform.eulerAngles = transform.eulerAngles - rotateValue;

        transform.eulerAngles = new Vector3( xRotation, transform.eulerAngles.y, transform.eulerAngles.z);

        //cam.transform.rotation *= Quaternion.Euler(xRotation, 0, 0);
        //transform.Rotate(xRotation, 0,0);




    }
    //void TestLook()
    //{
    //    transform.LookAt(target);

    //}

   
    

}
