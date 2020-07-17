using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienSpeech : MonoBehaviour
{
    public bool neptunesfail = false;
    AlienInput AI;
    AlienCollision AC;
    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        AI = FindObjectOfType<AlienInput>();
        AC = FindObjectOfType<AlienCollision>();
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact(int neptunesacquired)
    {
        AC.alien1riddlecontact = true;
        if (neptunesacquired == 0)
        {
            gameObject.GetComponent<Text>().text = "I see you have an eye for my treasure. Isn't it great? But it's MINE NOT YOURS!";
            
        }
        else if (neptunesacquired == 4)
        {
            gameObject.GetComponent<Text>().text = "I overheard you with my sister, but it's fine, she's right. Any song recommendations?";
        }
        else if (neptunesacquired == 1)
        {
            gameObject.GetComponent<Text>().text = AI.songreccomend + " you say? Let's have a listen... No.. This isn't what I'm looking for.";

            GM.songflag = true;
        }
        else if (neptunesacquired == 2)
        {
            gameObject.GetComponent<Text>().text = "Neptunes you say? Let's have a listen... Wow! Here, take my treasure as thanks.";

        }
        else if (neptunesacquired == 3)
        {
            gameObject.GetComponent<Text>().text = "Thanks for the recommendation! This is groovy.";
        }

    }

    public void InteractEnd()
    {
        gameObject.GetComponent<Text>().text = "";
        AC.alien1riddlecontact = false;
    }
}
