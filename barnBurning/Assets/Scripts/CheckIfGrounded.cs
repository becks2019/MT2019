using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfGrounded : MonoBehaviour
{

  public Collider playerCollider;
  public bool isGrounded;
  

  RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        isGrounded = PlayerGrounded();
        
    }
    
    //Dieses Skript checkt, ob der Player auf dem Boden steht, indem überprüft wird, ob der Collider des Players den Collider des Terrains/Bodens berührt


    bool PlayerGrounded(){
      return Physics.Raycast (transform.position, Vector3.down, out hit, playerCollider.bounds.extents.y + 0.5f);
    }

}
