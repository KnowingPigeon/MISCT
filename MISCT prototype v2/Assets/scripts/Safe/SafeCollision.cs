﻿using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class SafeCollision : MonoBehaviour
{
    SafeSpeech SS;
    GameManager GM;
    public bool alien1riddlecontact = false;
    public bool completedb = false;
    // Start is called before the first frame update
    void Start()
    {
        SS = FindObjectOfType<SafeSpeech>();
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        alien1riddlecontact = true;
        if (GM.codeoffflag == false)
        {
            SS.Interact(0);
        }
        else if (GM.codeoffflag == true)
        {
            SS.Interact(3);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        alien1riddlecontact = false;
        SS.InteractEnd();
    }
}
