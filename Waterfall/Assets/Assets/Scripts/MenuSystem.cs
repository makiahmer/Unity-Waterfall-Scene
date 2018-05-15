using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuSystem : MonoBehaviour
{
    public EventSystem eventSystem;
    private bool menuOpen = false;

    void FixedUpdate ()
    { // https://community.unity.com/t5/Scripting/Enable-Disable-GameObjects/m-p/2031123/highlight/true
        if (Input.GetKeyDown (KeyCode.P)
            || Input.GetKeyDown (KeyCode.M)
            && !menuOpen) {
            GameObject temp = transform.Find ("MainMenu").gameObject;
            if (temp != null)
                temp.SetActive (true);
            menuOpen = true;
        } else if (Input.GetKeyDown (KeyCode.P)
                   || Input.GetKeyDown (KeyCode.M)
                   && menuOpen) {
            GameObject temp = transform.Find ("MainMenu").gameObject;
            if (temp != null)
                temp.SetActive (false);
            menuOpen = false;
        }
    }

    public void ChangeScene (int sceneIndex)
    {
        SceneManager.LoadScene (sceneIndex);
    }

    public void ChangeMeditationType (string newType)
    {
        print ("Selected Type: " + newType);
        switch (newType) {
            case "BodyScan":
                break;
            case "Concentration":
                break;
            case "Relaxation":
                break;
            case "ObjectiveObserver":
                break;
            case "ExpandedAwareness":
                break;
            case "none":
            default:
                break;
        }
    }

    public void ChangeTracks (string trackName)
    {
        GameObject guide = GameObject.FindGameObjectWithTag ("MeditationGuide");

        if (trackName == "none") {
            guide.GetComponent<AudioSource> ().Stop ();
        } else if (trackName == "Cycle") {
            // Play all tracks
        } else {
            guide.GetComponent<AudioSource> ().clip = Resources.Load ("Assets/Assets/Audio/Meditation Tracks/" + trackName) as AudioClip;
        }
    }

    public void ChangeMenu (string nextMenu)
    {
        GameObject temp;
        temp = transform.Find ("MainMenu").gameObject;
        if (temp != null)
            temp.SetActive (false);
        temp = transform.Find ("ChangeScenes").gameObject;
        if (temp != null)
            temp.SetActive (false);
        temp = transform.Find ("ChangeMeditationTracks").gameObject;
        if (temp != null)
            temp.SetActive (false);
        temp = transform.Find ("Options").gameObject;
        if (temp != null)
            temp.SetActive (false);

        if (nextMenu != null && nextMenu != "") {
            temp = transform.Find (nextMenu).gameObject;
            if (temp != null)
                temp.SetActive (true);
            menuOpen = true;
        } else {
            menuOpen = false;
        }
    }

    public void ExitApplication ()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

public class AudioOptions : MonoBehaviour
{
    public void ChangeVolume (string audioGroup, string newVolume)
    {
    }
}
