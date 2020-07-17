using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsCollider : MonoBehaviour
{
    InstructionsSpeech IS;
    GameManager GM;

    // Start is called before the first frame update
    void Start()
    {
        IS = FindObjectOfType<InstructionsSpeech>();
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GM.winflag == false)
        {
            IS.Interact(false);
        }
        else if (GM.winflag == true)
        {
            IS.Interact(true);
        }


    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        IS.InteractEnd();
    }
}
