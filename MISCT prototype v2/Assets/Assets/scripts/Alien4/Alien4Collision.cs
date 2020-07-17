using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien4Collision : MonoBehaviour
{
    Alien4Speech A4S;
    GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        A4S = FindObjectOfType<Alien4Speech>();
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GM.codeoffflag == true)
        {
            A4S.Interaction(2);
        }
        else if(GM.codeoffflag == false)
        {
            A4S.Interaction(0);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        A4S.InteractionEnd();
    }
}
