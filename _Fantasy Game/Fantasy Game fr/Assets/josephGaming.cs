using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class josephGaming : MonoBehaviour
{
    // Joseph do what joseph pleases
    void Start()
    {
        gaming(69);
    }

    void Update()
    {
        
    }

    void gaming(int k)
    {
        if (k>0)
        {
            gaming(k - 1);
        }
        else
        {
            Debug.Log("schmingus");
        }
    }
}
