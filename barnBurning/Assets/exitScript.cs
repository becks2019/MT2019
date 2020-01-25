using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScript : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		StartCoroutine("QuitGame");
	}

	IEnumerator QuitGame()
	{
		yield return new WaitForSeconds(5);
		Application.Quit();
	}

}
