using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class AlienRiddleSpeech : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact()
    {
        new Thread(() =>
        {
            Thread.CurrentThread.IsBackground = true;
            /* run your code here */
            gameObject.GetComponent<Text>().text = "Hello Offworlder.";
            Thread.Sleep(500);
            gameObject.GetComponent<Text>().text = "Hello Offworlder. What do you want?";
            Thread.Sleep(500);
            gameObject.GetComponent<Text>().text = "Hello Offworlder. What do you want?r";
        }).Start();
    }
    public void InteractEnd()
    {
        gameObject.GetComponent<Text>().text = "";
    }
}
