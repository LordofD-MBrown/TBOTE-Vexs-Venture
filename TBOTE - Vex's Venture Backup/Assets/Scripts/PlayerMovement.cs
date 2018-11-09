using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = 30f;
    public Vector3 move = Vector3.zero;

    public GameObject camera;

    JumpScareWraith jumpScareWraith;
    CharacterController controller;
    PlayerClass player;

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        player = gameObject.GetComponent<PlayerClass>();
        jumpScareWraith = camera.GetComponent<JumpScareWraith>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        if (controller.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            move = transform.TransformDirection(move);
            move *= speed;
        }

        move.y -= gravity * Time.deltaTime;

        controller.Move(move * Time.deltaTime);
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wraith")
        {
            jumpScareWraith.enabled = true;
            Destroy(other.gameObject);
        }
    }

}