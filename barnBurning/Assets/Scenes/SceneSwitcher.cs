using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    public void OnTriggerEnter(Collider collider)
    {
    SceneManager.LoadScene(2);
    }

   
}
