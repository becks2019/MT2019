using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseTrigger : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		GetComponent<AudioSource>().Play();
	}
}
