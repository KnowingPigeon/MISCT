using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeInput : MonoBehaviour
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
            if (GameObject.Find("InputField").GetComponent<InputField>().text.Contains("1234") && trollpartfound == false)
            {
                gameObject.GetComponent<Text>().text = "You solved the code";
                trollpartfound = true;
                GM.PartCollide();
            }
        }
    }
}
