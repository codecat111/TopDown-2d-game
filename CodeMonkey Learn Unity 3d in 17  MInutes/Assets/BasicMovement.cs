using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float moveSpeed = 5f;
    Vector3 movementVector = new Vector3(0,0,0);
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.z = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.velocity = movementVector;
    }
}
