using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeSpeech : MonoBehaviour
{
    GameManager GM;
    SafeCollision SC;
    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        SC = FindObjectOfType<SafeCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InteractionEnd()
    {
        gameObject.GetComponent<Text>().text = "";
    }
    public void Interaction(int Interactiontype)
    {
        SC.safecolliding = true;
        if (Interactiontype == 0) 
        {
            gameObject.GetComponent<Text>().text = "Enter password.";
        }
        else if (Interactiontype == 1)
        {
            gameObject.GetComponent<Text>().text = "Safe Unlocked.";
        }
        else if (Interactiontype == 2)
        {
            gameObject.GetComponent<Text>().text = "Inocorrect password.";
        }
        else if (Interactiontype == 3)
        {
            gameObject.GetComponent<Text>().text = "Correct password. Unlocking...";
            GM.codeoffflag = true;
        }
    }
}
