using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienInput : MonoBehaviour
{    // Start is called before the first frame update
    GameManager GM;
    AlienSpeech AS;
    AlienCollision AC;
    public string songreccomend;
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        AS = FindObjectOfType<AlienSpeech>();
        AC = FindObjectOfType<AlienCollision>();
    }

    // Update is called once per frame
    void Update()
    {


            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (GameObject.Find("InputField").GetComponent<InputField>().text.Contains("Neptunes") && GM.songcompleted == false && AC.alien1riddlecontact == true && GM.neptuneflag == true)
                {
                    GM.songcompleted = true;
                    AS.Interact(2);
                    AC.completedb = true;
                    GM.PartCollide();

                }
                else if (GM.songcompleted == false && AC.alien1riddlecontact == true && GM.neptuneflag == true)
                {
                    songreccomend = GameObject.Find("InputField").GetComponent<InputField>().text.ToString();
                    print(songreccomend);
                    AS.Interact(1);
                }
            }
        
    }


}
