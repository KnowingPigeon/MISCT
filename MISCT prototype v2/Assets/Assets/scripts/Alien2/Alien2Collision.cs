using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien2Collision : MonoBehaviour
{
    // Start is called before the first frame update
    Alien2Speech A2S;
    GameManager GM;
    void Start()
    {
        A2S = FindObjectOfType<Alien2Speech>();
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GM.songcompleted == false)
        {
            A2S.Interact(0);
        }
        else if (GM.songcompleted == true)
        {
            A2S.Interact(1);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        A2S.InteractEnd();
    }
}
