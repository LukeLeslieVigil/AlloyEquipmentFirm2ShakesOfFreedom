using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private Vector3 rotation;

    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float rotationSpeed = 180f;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        //Gets the inputs from the keyboard set using project settings
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //controller.Move(move * Time.deltaTime * playerSpeed);

        //Moves the player forward based on inputs
        //if (move != Vector3.zero)
        //{
        //    gameObject.transform.forward = move;
        //}

        //controller.Move(playerVelocity * Time.deltaTime);

        //Gets the rotation vector and the forward and backwards rotation vector
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime, 0);
        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);

        //Then moves the character in the actual direction and allows it to rotate as it moves
        move = this.transform.TransformDirection(move);
        controller.Move(move * playerSpeed);
        this.transform.Rotate(this.rotation);
    }
}
