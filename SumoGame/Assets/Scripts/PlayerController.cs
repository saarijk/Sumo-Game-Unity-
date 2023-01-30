using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerBody;
    private GameObject focalPoint;

    [SerializeField] private float speed = 5.0f;

    private void Start()
    {
        playerBody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    private void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerBody.AddForce(focalPoint.transform.forward * speed* forwardInput);
    }
}
