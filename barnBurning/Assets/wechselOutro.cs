using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class wechselOutro : MonoBehaviour
{

    //Dieses Skript wechselt die Szene, wenn der Collider am Grab betreten wird
	void OnTriggerEnter(Collider other)
	{

        //Wechsel zu Szene 3, dem Outro
		SceneManager.LoadScene(3);

	}

}
