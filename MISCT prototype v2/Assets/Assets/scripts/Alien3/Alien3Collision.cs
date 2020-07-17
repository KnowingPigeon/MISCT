using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien3Collision : MonoBehaviour
{
    Alien3Speech A3S;
    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        A3S = FindObjectOfType<Alien3Speech>();
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GM.songflag == true)
        {
            A3S.Interaction(1);
        }
        else if (GM.songflag == false)
        {
            A3S.Interaction(0);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        A3S.InteractionEnd();
    }
}
