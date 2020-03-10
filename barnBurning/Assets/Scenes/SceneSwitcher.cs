using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    public void OnTriggerEnter(Collider collider) // Trigger Funktion, wenn Kamera mit Trigger kollidiert, soll die nächste Szene geladen
                                                   //  werden
    {
    SceneManager.LoadScene(2);
    }

   
}
