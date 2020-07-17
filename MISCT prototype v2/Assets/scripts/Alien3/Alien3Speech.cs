using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alien3Speech : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interaction(int interactiontype)
    {
        if (interactiontype == 0)
        {
            gameObject.GetComponent<Text>().text = "I parsed a signal from a faraway planet! Someone seems to be broadcasting... Earthling music.";
        }
        else if (interactiontype == 1)
        {
            gameObject.GetComponent<Text>().text = "I am going to make a remix of your Earthling music and my favorite song Neptunes!";
        }
    }
    public void InteractionEnd()
    {
        gameObject.GetComponent<Text>().text = "";
    }
}
