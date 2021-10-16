using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float camSpeed = 2.0f;
   
    public Rigidbody pl;
    
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        pl = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontalAxis = Input.GetAxis("Horizontal");
        //float verticalAxis = Input.GetAxis("Vertical");

        
        

       

        //Vector3 desiredMoveDirection = new Vector3(horizontalAxis * right  , 0, verticalAxis);

        //transform.Translate(desiredMoveDirection * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * camSpeed, 0);

       
        //pl.AddForce(desiredMoveDirection * speed);
        if (Input.GetKey("d"))  pl.AddForce(transform.right * speed);
        if (Input.GetKey("a")) pl.AddForce(transform.right * speed * -1);
        if (Input.GetKey("w")) pl.AddForce(transform.forward * speed );
        if (Input.GetKey("s")) pl.AddForce(transform.forward * speed * -1);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
