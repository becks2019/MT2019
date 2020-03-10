using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LoadSceneAfterVideoEnded : MonoBehaviour
{
    public VideoPlayer VideoPlayer; // implemntieren des VideoPlayer für das Abspielen des Videos (Intro)
    void Start() // Videoplayer starten
    {
        VideoPlayer.loopPointReached += LoadScene; // die Zeile ist dafür da, damit wenn das Video zu ende ist, die nächste Szene lädt
    }
    void LoadScene(VideoPlayer vp) // Diese Funktion ist dann dafür da, die jeweils ausgewählt Szene dann zu laden
    {
        SceneManager.LoadScene(1); // hier mit paramter angeben, welche Szene geladen werden soll 
    }
}
