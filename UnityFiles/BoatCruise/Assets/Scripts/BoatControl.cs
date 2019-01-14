using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatControl : MonoBehaviour
{
    public GameObject motor = null;
    public float rotAmount;

    private MotorForce motorForce;
    private Rigidbody boatRb;

    // Use this for initialization
    void Start()
    {
        motorForce = motor.GetComponent<MotorForce>();
        boatRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputCheck();
    }

    void InputCheck()
    {
        if (Input.GetKey(KeyCode.D))
        {
            motor.transform.Rotate(0, rotAmount, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            motor.transform.Rotate(0, -rotAmount, 0);
        }
    }
}
