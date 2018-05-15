using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;
using UnityEngine.Audio;

public class PlayerPreferences : MonoBehaviour
{

    private class AudioSettings
    {
        int masterVolume = 100;
        int meditationTrackVolume = 100;
        int environmentVolume = 100;
    };


    private class GraphicsSettings
    {

    };

    private class MeditationGuideSettings
    {

    };

    private class PlayerSettings
    {

    };


    private class Preferences
    {
        // Default to Body Scan
        String meditationType = "BodyScan";

        // Cycles all tracks
        String meditationTrack = "Cycle";

        AudioSettings audioSettings = new AudioSettings ();
        GraphicsSettings graphicsSettings = new GraphicsSettings ();
        MeditationGuideSettings guideSettings = new MeditationGuideSettings ();
        PlayerSettings playerSettings = new PlayerSettings ();
    };

    Preferences playerPrefs = new Preferences ();

    // Use this for initialization
    void Start ()
    {
        /*==== Get Settings From File ====*/
        //---- Get Meditaiton Settings ----
        //playerPrefs.meditationType = PlayerPrefs.GetString ("meditationType");
        //playerPrefs.meditationTrack = PlayerPrefs.GetString ("meditationTrack");

        //---- Get Audio Settings ----
        //playerPrefs.audioSettings.masterVolume = PlayerPrefs.GetInt ("masterVolume");
        //playerPrefs.audioSettings.meditationTrackVolume = PlayerPrefs.GetInt ("meditationTrackVolume");
        //playerPrefs.audioSettings.environmentVolume = PlayerPrefs.GetInt ("environmentVolume");

        //---- Get Graphics Settings ----
        //playerPrefs.meditationType = PlayerPrefs.GetString ("meditationType");

        //---- Get Meditation Guide Settings ----

        //---- Get Player Settings ----



        /*==== Update Scene With Settings ====*/
        //---- Set Meditation Settings ----
        // Set Set Scene Values
        // Set Menu Values

        //---- Set Audio Settings ----
        // Set Sound Mixer
        // Set Menu Values

        //---- Set Graphics Settings ----
        // Set Set Scene Values
        // Set Menu Values

        //---- Set Meditation Guide Settings ----
        // Set Set Scene Values
        // Set Menu Values

        //---- Set Player Settings ----
        // Set Set Scene Values
        // Set Menu Values
    }
}
