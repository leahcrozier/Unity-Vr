using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class lampscript : MonoBehaviour
{


    public UnityEvent onPressed, onReleased; 

    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {

        if (this.GetComponent<Light>().enabled = true)
        {
            Debug.Log("light off");
            this.GetComponent<Light>().enabled = false;
        }
            
            
        if (this.GetComponent<Light>().enabled = false)
        {
            Debug.Log("light on");
            this.GetComponent<Light>().enabled = true;

        }
            
            
    }
}
