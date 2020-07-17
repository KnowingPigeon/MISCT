using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int partscollected = 0;
    public bool neptuneflag = false;
    public bool songflag = false;
    public bool songcompleted = false;
    public bool codeflag = false;
    public bool codeoffflag = false;
    public bool winflag = false;
    AudioSource myAudio;
    [Tooltip("The sound that plays when a part is collected")]
    public AudioClip PartCollectionSound;
    InstructionsSpeech IS;
    // Start is called before the first frame update
    void Start()
    {
        IS = FindObjectOfType<InstructionsSpeech>();
    }

    // Update is called once per frame
    void Update()
    {
        if (partscollected == 2)
        {
            winflag = true;
            
        }
    }

    public void PartCollide()
    {
        partscollected += 1;
        print(partscollected);
        AudioSource PartCollectionSound = gameObject.GetComponent<AudioSource>();
        PartCollectionSound.Play();

    }
}
