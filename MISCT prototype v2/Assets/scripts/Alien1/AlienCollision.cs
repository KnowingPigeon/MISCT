using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienCollision : MonoBehaviour
{
    AlienSpeech AS;
    GameManager GM;
    public bool alien1riddlecontact = false;
    public bool completedb = false;
    // Start is called before the first frame update
    void Start()
    {
        AS = FindObjectOfType<AlienSpeech>();
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GM.songcompleted == true)
        {
            AS.Interact(3);
        }
        else if (GM.neptuneflag == true)
        {
            AS.Interact(4);
        }
        else if (GM.songcompleted == false)
        { 
            AS.Interact(0);
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        AS.InteractEnd();
    }
}
