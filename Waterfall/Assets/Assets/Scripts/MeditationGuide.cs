/*
 * This script will 
 * 1) Handle the guide's trailing of the player
 * 2) Handle the transition of audio tracks
 * 3) Animation of the meditation guide around player (i.e. bobbing, circling, & rotating)
 */

using UnityEngine;
using System.Collections;

public class MeditationGuide : MonoBehaviour {
    public bool guideBobActive = true;
    public float guideBobSpeed = 0.5F;
    public float guideBobAmplitude = 0.15F;
    public Vector3 guideDistanceFromPlayer = new Vector3(1F, 0.25F, 1F);

    // Guide needs a 3d Object to rotate, currently its just a light and flare.
    public bool guideRotateActive = false;
    public float guideRotateSpeed = 0.25F;

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        float y0 = playerPos.y + guideDistanceFromPlayer.y;

        // Determine new position
        Vector3 newPos = new Vector3();
        newPos.x = playerPos.x + guideDistanceFromPlayer.x;
        if(guideBobActive)
        {
            newPos.y = (y0 + guideBobAmplitude * Mathf.Sin(guideBobSpeed * Time.time));
        }
        else
        {
            newPos.y = y0;
        }
        newPos.z = playerPos.z + guideDistanceFromPlayer.z;

        // Set new position
        transform.position = newPos;

        // Rotate a little bit
        if (guideRotateActive)
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * guideRotateSpeed);
        }
    }


    void FixedUpdate()
    {

    }
}
