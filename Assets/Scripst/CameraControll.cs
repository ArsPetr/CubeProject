using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public float camSpeed = 2.0f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * camSpeed, 0);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
