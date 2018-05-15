/*
 * https://www.youtube.com/watch?v=FoZwgRE5LYI
 */
using UnityEngine;
using System.Collections;

public class UnderwaterEffects : MonoBehaviour
{
    public GameObject player;
    public GameObject lake;
    public GameObject bubbleEmitter;
    public Color underwaterColor = new Color(47, 69, 74, 128);
    public Color normalColor = new Color(0.5F, 0.5F, 0.5F, 0F);
    public float normalFogDensity = 0F;
    public float underwaterFogDensity = 0.025F;
    //private bool playerUnderwater = false;

    public bool enableBubbleEmitter = false;
    private Vector3 bubbleOffset;

    // Use this for initialization
    void Start () 
    {
        //bubbleEmitter.transform.position = new Vector3(player.transform.position.x + 1F, player.transform.position.y, player.transform.position.z);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //bubbleOffset = bubbleEmitter.transform.position - player.transform.position;
    }

    void FixedUpdate()
    { }
    
    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        //bubbleEmitter.transform.position = player.transform.position + bubbleOffset;
    }
    
    void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
        {
            if (player.transform.position.y < lake.transform.position.y)
            {
                SetUnderwater();
            }
            else
            {
                SetNormal();
            }
        }
    }

    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            if (player.transform.position.y < lake.transform.position.y)
            {
                SetUnderwater();
            }
            else
            {
                SetNormal();
            }
        }
    }

    void SetUnderwater()
    {
        RenderSettings.fogColor = underwaterColor;
        RenderSettings.fogDensity = underwaterFogDensity;
        //playerUnderwater = true;
        if(enableBubbleEmitter) bubbleEmitter.SetActive(true);
    }

    void SetNormal()
    {
        RenderSettings.fogColor = normalColor;
        RenderSettings.fogDensity = normalFogDensity;
        //playerUnderwater = false;
        if (enableBubbleEmitter) bubbleEmitter.SetActive(false);
    }
}
