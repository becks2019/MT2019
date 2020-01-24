using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){
      GetComponent<AudioSource>().Play();
    }

    void OnTriggerExit(Collider other){
      GetComponent<AudioSource>().Stop();
    }
}
