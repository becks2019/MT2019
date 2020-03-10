using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    //Dieses Skript startet die Animation, mit der der Zaun zur Grabstelle geöffnet wird
    //Die Animation wird erst durch Betreten eines BoxColliders ausgeführt
	private Animator _animator;

    void Start()
    {
		//ruft den Animator auf
		_animator = GetComponent<Animator>();
        
    }

	//bei Betreten des Colliders wird folgende Funktion ausgeführt
	void OnTriggerEnter(Collider other)
	{
		//der Parameter open im Animator wird auf true gesetzt, die Animation wird gestartet
		_animator.SetBool("open", true);
	}

}
