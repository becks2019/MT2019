using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

  public Light flashlight;
  public bool activateFlashlight;
    // Start is called before the first frame update
    void Start()
    {
        flashlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        flashlight.enabled = activateFlashlight;
        if(Input.GetKeyDown("f")){
          activateFlashlight = !activateFlashlight;
        }
    }
}
