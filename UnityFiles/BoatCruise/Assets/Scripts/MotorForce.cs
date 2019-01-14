using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorForce : MonoBehaviour
{
    public GameObject boat = null;
    public float forcePower = 0.0f;

    private Rigidbody thisRb;

    // Use this for initialization
    void Start()
    {
        thisRb = boat.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        thisRb.AddForce(-gameObject.transform.forward * Time.deltaTime * forcePower , ForceMode.Force);
    }
}
