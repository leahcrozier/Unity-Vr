using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KraanWater : MonoBehaviour
{

    public GameObject water;
    private bool on = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Kraanwater();
        on = !on;
    }


    public void Kraanwater()
    {
        if (on)
        {
            Debug.Log("kraan off");
            GameObject.Find("water").transform.localScale = new Vector3(0f, 0f, 0f);
            on = false;

        }


        else
        {
            Debug.Log("kraan on");
            GameObject.Find("water").transform.localScale = new Vector3(0.0773824826f, 0.282643974f, 0.0773824826f);
            on = true;


        }

    

    }
}
