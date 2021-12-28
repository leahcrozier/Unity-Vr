using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class lampscript2 : MonoBehaviour
{


    public GameObject light;
    private bool on = true;
    Light mylight;

    // Start is called before the first frame update
    void Start()
    {

        mylight = GetComponent<Light>();
        

    }

    // Update is called once per frame
    void Update()
    {
        LightSwitch();
        on = !on;
           
        

    }

    public void LightSwitch()
    {
        if (on)
        {
            Debug.Log("light off");
            //this.GetComponent<Light>().enabled = false;
            mylight.intensity = 0.0f;
            on = false;
            
        }


        else
        {
            Debug.Log("light on");
            //this.GetComponent<Light>().enabled = true;
            mylight.intensity = 1.5f;
            on = true;
            

        }

   

    }













}
