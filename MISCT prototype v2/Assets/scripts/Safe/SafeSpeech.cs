using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class SafeSpeech : MonoBehaviour
{
    public bool neptunesfail = false;
    SafeInput SI;
    SafeCollision SC;
    GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        SI = FindObjectOfType<SafeInput>();
        SC = FindObjectOfType<SafeCollision>();
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Interact(int neptunesacquired)
    {
        SC.alien1riddlecontact = true;
        if (neptunesacquired == 0)
        {
            gameObject.GetComponent<Text>().text = "Enter passcode.";
        }
        if (neptunesacquired == 1)
        {
            gameObject.GetComponent<Text>().text = "Unlocked.";
        }
        if (neptunesacquired == 3)
        {
            gameObject.GetComponent<Text>().text = "Incorrect passcode.";
        }

    }

    public void InteractEnd()
    {
        gameObject.GetComponent<Text>().text = "";
        SC.alien1riddlecontact = false;
    }
}
