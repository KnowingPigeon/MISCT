using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeCollision : MonoBehaviour
{
    public bool safecolliding = false;
    SafeSpeech SS;
    GameManager GM;
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
        if (GM.codeoffflag == false) {

            SS.Interaction(0);
        }
        else if (GM.codeoffflag == true)
        {
            SS.Interaction(1);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        SS.InteractionEnd();
    }
}
