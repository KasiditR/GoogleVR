using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrLookWalk : MonoBehaviour
{
    [SerializeField] private Transform vrCamera;
    [SerializeField] private float toggleAngle = 30.0f;
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private bool moveForward;

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if(vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            characterController.SimpleMove(forward * speed);
        }
    }
}
