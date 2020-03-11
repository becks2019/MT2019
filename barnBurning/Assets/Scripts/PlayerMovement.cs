using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Fortbewegung des Players mit Keyboard oder Controller
    public CharacterController controller;

    public float speed = 2f;
    public float gravity = -9.81f;
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        // Input vom Standort auf den Achsen: Horizontal und Vertical
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // die Bewegung wird mit der deklarierten Geschwindigkeit multipliziert und der Geschwindigkeit des Geräts
        controller.Move(move * speed * Time.deltaTime);
        // die Schwerkraft wird mit einberechnet
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


    }
}
