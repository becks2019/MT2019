using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fackelTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    // private GameObject fackel;
    // void Start() {
    //     fackel = GameObject.Find("fackel");
    //     fackel.gameObject.SetActive(false);
    // }
    // void OnTriggerEnter (Collider other) {
    //     // if (other.CompareTag ("Player")) {
    //         fackel.gameObject.SetActive(true);
    //     // }
    // }

    // void OnTriggerExit (Collider other) {
    //     if (other.CompareTag ("Player")) {
    //         fackel.gameObject.SetActive(false);
    //     }
    // }

    void onTriggerEnter(Collider other){
      Debug.Log("Object within trigger");
    }

    void onTriggerStay(Collider other){
      Debug.Log("Object within trigger");
    }

    void onTriggerExit(Collider other){
      Debug.Log("Object NOT within trigger");
    }
}
