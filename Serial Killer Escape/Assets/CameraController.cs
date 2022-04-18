using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject blackOut;

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
            blackOut.SetActive(false);
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Fade to black");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        blackOut.SetActive(true);
        Debug.Log("Unfade from black");
    }
}
