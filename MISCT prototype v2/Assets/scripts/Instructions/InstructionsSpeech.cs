using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsSpeech : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact(bool win)
    {
        if (win == false)
        {
            gameObject.GetComponent<Text>().text = "Ship crashlanded. Please find both missing parts and return here to regain fuctionality. WASD to move.";
        }
        else if (win == true)
        {
            gameObject.GetComponent<Text>().text = "Parts found. Reassembling.";
            Thread.Sleep(2000);
            gameObject.GetComponent<Text>().text = "You win!";
            Thread.Sleep(3000);
            Application.Quit();
        }
    }
    public void InteractEnd()
    {
        gameObject.GetComponent<Text>().text = "";
    }
}
