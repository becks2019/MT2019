using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LoadSceneAfterVideoEnded : MonoBehaviour
{
    public VideoPlayer VideoPlayer; // Videpplayer deklarieren
    void Start() //Videoplayer starten
    {
        VideoPlayer.loopPointReached += LoadScene; // Wenn Video beendet ist, lädt Szene
    }
    void LoadScene(VideoPlayer vp) // Funktion zum Szene laden
    {
        SceneManager.LoadScene(1); // Angabe, welche Szene geladen wird 
    }
}
