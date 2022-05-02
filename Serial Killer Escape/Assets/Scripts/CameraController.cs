using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject blackOut;
    private float fadeDuration = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.collider.tag == "Wall" || collision.collider.tag == "Door")
        {
            //FadeToBlack()
            blackOut.SetActive(true);
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Fade to black");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        //FadeFromBlack()
        blackOut.SetActive(false);
        Debug.Log("Unfade from black");
    }

    private void FadeToBlack()
    {
        //Set start color 
        //SteamVR_Fade.Start(Color.clear, 0f);
        //Set and start fade to black operation
        //SteamVR_Fade.start(Color.black, fadeDuration);
    }

    private void FadeFromBlack()
    {
        //Set start color though idk why since it should already be set to black by the time this function is called
        //SteamVR_Fade.Start(Color.black, 0f);
        //Set and start fade to clear
        //SteamVR_Fade.Start(Color.clear, fadeDuration);
    }
}
