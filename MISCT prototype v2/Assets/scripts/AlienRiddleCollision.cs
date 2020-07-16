using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienRiddleCollision : MonoBehaviour
{
    AlienRiddleSpeech ARS;
    // Start is called before the first frame update
    void Start()
    {
        ARS = FindObjectOfType<AlienRiddleSpeech>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ARS.Interact();
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        ARS.InteractEnd();
    }
}
