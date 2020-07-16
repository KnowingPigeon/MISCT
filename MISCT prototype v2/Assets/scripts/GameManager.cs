using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int partscollected = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (partscollected == 2)
        {
            print("You win!");
        }
    }

    public void PartCollide()
    {
        partscollected += 1;
        print(partscollected);
    }
}
