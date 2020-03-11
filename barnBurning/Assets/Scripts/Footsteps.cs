using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
  // Skript ist zuständig für die Ausgabe der Audioclips beim gehen
  // es gibt ein Array mit unterschiedlich klingenden Schritten, um ein natürliches Gehgeräusch zu erzeugen
  // zufällig wird ein Clip aus dem Array abgespielt

  // nur wenn der Player auf dem Boden ist, werden die Audiodateien der Schritte abgespielt
    public CheckIfGrounded checkIfGrounded;

    public AudioSource audioSource;
    public AudioClip[] dirtClips;
    public AudioClip previousClip;

    CharacterController character;
    float currentSpeed;
    bool walking;
    float distanceCovered;
    public float modifier=1f;

    void Start(){
        character = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = GetPlayerSpeed();
        walking = CheckIfWalking();

      // wenn der Player sich bewegt, werden neue Audioclips abgerufen
        if(walking){
            TriggerNextClip();
        }
    }

    float GetPlayerSpeed(){
      float speed = character.velocity.magnitude;
      return speed;
    }

    // überprüft, ob sich der Spieler bewegt
    bool CheckIfWalking(){
      if(currentSpeed > 0 && checkIfGrounded.isGrounded){
        return true;
      } else {
        return false;
      }
    }

    // aus dem Array mit den Audiodateien wird ein zufälliger Clip zürückgegeben
    AudioClip GetClipFromArray(AudioClip[] clipArray){
      int attempts = 3;
      AudioClip selectedClip = clipArray [Random.Range(0, clipArray.Length -1)];

      while (selectedClip == previousClip && attempts > 0){
        selectedClip = clipArray [Random.Range (0, clipArray.Length -1)];
        attempts--;
      }
      previousClip = selectedClip;
      return selectedClip;
    }

    // wird aufgerufen, wenn der Player sich bewegt
    void TriggerNextClip(){
      if(checkIfGrounded){
        audioSource.PlayOneShot(GetClipFromArray(dirtClips), 1 );
      }
    }
}
