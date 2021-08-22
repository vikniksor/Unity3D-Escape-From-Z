using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{

    
    private bool isCalled = false;
    private Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    
    public void OnDispatchHelicopter()
    {
        // For this if statement need to create a message for player on screen.
        // if (Input.GetButtonDown("CallHeli") && !isCalled) { isCalled = true; }

        rigidBody.velocity = new Vector3(0, 0, 50f);
        isCalled = true;
    }
}
