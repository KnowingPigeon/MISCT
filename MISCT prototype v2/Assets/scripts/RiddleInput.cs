using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RiddleInput : MonoBehaviour
{    // Start is called before the first frame update
    bool trollpartfound = false;
    GameManager GM;
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameObject.Find("InputField").GetComponent<InputField>().text.Contains("river") && trollpartfound == false)
            {
                gameObject.GetComponent<Text>().text = "You solved the riddle";
                trollpartfound = true;
                GM.PartCollide();
            }
        }
    }
}
