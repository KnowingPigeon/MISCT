using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeInput : MonoBehaviour
{    // Start is called before the first frame update
    GameManager GM;
    SafeSpeech SS;
    SafeCollision SC;
    Alien4Speech A4S;
    public string songreccomend;
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        SS = FindObjectOfType<SafeSpeech>();
        SC = FindObjectOfType<SafeCollision>();
        A4S = FindObjectOfType<Alien4Speech>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameObject.Find("InputField").GetComponent<InputField>().text.Contains("5231") && SC.alien1riddlecontact == true && GM.codeoffflag == false)
            {
                GM.codeoffflag = true;
                A4S.Interaction(1);
                SC.completedb = true;
                GM.PartCollide();

            }
            else if (GM.songcompleted == false && SC.alien1riddlecontact == true && GM.codeoffflag == false)
            {
                SS.Interact(1);
            }
        }

    }


}
