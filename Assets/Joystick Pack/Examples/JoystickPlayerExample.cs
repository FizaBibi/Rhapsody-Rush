using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public FixedJoystick fixedJoystick;
    //public Rigidbody rb;
    public float speed;

    [SerializeField] private Vector3 pos;

    [SerializeField] private float xRangeRight;
    [SerializeField] private float xRangeLeft;
    [SerializeField] private float zRangeTop;
    [SerializeField] private float zRangeBottom;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * fixedJoystick.Vertical + Vector3.right * fixedJoystick.Horizontal;
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        transform.Translate(direction * Time.deltaTime * speed);

        if (transform.position.x > xRangeRight)
            transform.position = new Vector3(xRangeRight, transform.position.y, transform.position.z);
        if (transform.position.x < xRangeLeft)
            transform.position = new Vector3(xRangeLeft, transform.position.y, transform.position.z);
        if (transform.position.z > zRangeTop)
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        if (transform.position.z < zRangeBottom)
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBottom);
        pos = transform.position;
    }
}
