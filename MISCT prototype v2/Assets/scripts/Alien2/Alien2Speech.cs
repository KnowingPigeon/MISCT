using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public class Alien2Speech : MonoBehaviour
{
    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact(int interactiontype)
    {
        if (interactiontype == 0)
        {
            gameObject.GetComponent<Text>().text = "Sorry about my brother, he's irritable without any new songs to listen to.";
            GM.neptuneflag = true;
        }
        else if (interactiontype == 1)
        {
            gameObject.GetComponent<Text>().text = "Are you the one who told my brother about Neptunes? Thanks! You got my brother to shut up, and gave me a new favorite song!";
        }
    }
    public void InteractEnd()
    {
        gameObject.GetComponent<Text>().text = "";
    }
}
