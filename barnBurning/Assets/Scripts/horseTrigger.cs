using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseTrigger : MonoBehaviour
{

    //Dieses Skript startet die Audiodatei vom Pferd
    //bei Betreten des Colliders wird folgende Funktion ausgeführt
	void OnTriggerEnter(Collider other)
	{
        
        //Die Audiodatei wird gestartet
		GetComponent<AudioSource>().Play();
	}
}
