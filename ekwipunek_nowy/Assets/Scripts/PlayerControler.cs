using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float movementSpeed = 4;
    //private Inventory inventory;

    Camera camera;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        camera = GetComponentInChildren<Camera>();

        //inventory = new Inventory();
    }

    // Update is called once per frame
    void Update()
    {
        Walking();
        HandleHorizontalRotation();
        HandleVerticalRotation();
    }

    void Walking()
    {
        var userKeyboardInput = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")
        );
        var velocity = transform.rotation * userKeyboardInput * movementSpeed;
        if (Input.GetKey(KeyCode.LeftShift)) velocity = velocity * 2;
        velocity.y = rigidbody.velocity.y;
        rigidbody.velocity = velocity;
    }

    void HandleHorizontalRotation()
    {
        var mouseHorizontalRotation = Input.GetAxis("Mouse X");
        var newRotation = transform.localRotation.eulerAngles;
        newRotation.y = newRotation.y + mouseHorizontalRotation;
        transform.localRotation = Quaternion.Euler(newRotation);
    }

    void HandleVerticalRotation()
    {
        var mouseVerticalRotation = Input.GetAxis("Mouse Y");
        var camRot = camera.transform.rotation.eulerAngles;
        camRot.x = camRot.x - mouseVerticalRotation;
        camera.transform.rotation = Quaternion.Euler(camRot);
    }
}
