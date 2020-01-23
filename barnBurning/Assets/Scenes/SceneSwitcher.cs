using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour {

    public void OnTriggerEnter(Collider collider)
    {
    Debug.Log("Hallo");
    SceneManager.LoadScene(0);
    }

   
}
