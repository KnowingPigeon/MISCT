using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alien4Speech : MonoBehaviour
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
    public void InteractionEnd()
    {
        gameObject.GetComponent<Text>().text = "";
    }
    public void Interaction(int interactiontype)
    {
        if (interactiontype == 0)
        {
            gameObject.GetComponent<Text>().text = "*sob sob* I set a password for my safe and made a secret code, but I forgot the cipher! Please help! The code is $-#+";
            GM.codeflag = true;
        }
        if (interactiontype == 1)
        {
            gameObject.GetComponent<Text>().text = "You opened it! You can have this machinery, and I get my joke book back!";
        }
        if (interactiontype == 2)
        {
            int randnum = Random.Range(1, 6);
            if (randnum == 1)
            {
                gameObject.GetComponent<Text>().text = "What is a martians favorite chocolate bar? A Mars bar!";
            }
            else if (randnum == 2)
            {
                gameObject.GetComponent<Text>().text = "What is an aliens favorite place on a computer? The space bar!";
            }
            else if (randnum == 3)
            {
                gameObject.GetComponent<Text>().text = "Where would an alien park his space ship? A parking meteor!";
            }
            else if (randnum == 4)
            {
                gameObject.GetComponent<Text>().text = "What kind of currency do aliens use? Starbucks!";
            }
            else if (randnum == 5)
            {
                gameObject.GetComponent<Text>().text = "What do you get when you cross an airplane with a magician? A flying sorcerer!";
            }
        }
    }
}
