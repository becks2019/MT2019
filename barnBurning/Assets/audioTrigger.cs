using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTrigger : MonoBehaviour
{
    //Dieses Skript startet die Audiodatei von Bullen, Fluss und Blätterrauschen
    //bei Betreten des Colliders wird folgende Funktion ausgeführt
    void OnTriggerEnter(Collider other){
    
       //Die Audiodatei wird gestartet
      GetComponent<AudioSource>().Play();
    }


    //bei Verlassen des Colliders wird folgende Funktion ausgeführt
    void OnTriggerExit(Collider other){
    
       //Die Audiodateo wird gestoppt
      GetComponent<AudioSource>().Stop();
    }
}
