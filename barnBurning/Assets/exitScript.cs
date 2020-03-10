using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScript : MonoBehaviour
{
	
    //Dieses Skript beendet die Anwendung bei Betreten eines Boxcolliders am Grab
    void OnTriggerEnter(Collider other)
	{
		StartCoroutine("QuitGame");
	}

	IEnumerator QuitGame()
	{
        //Die Anwendung wird nach einem Ablauf von 5 Sekunden beendet 
		yield return new WaitForSeconds(5);
		Application.Quit();
	}

}
