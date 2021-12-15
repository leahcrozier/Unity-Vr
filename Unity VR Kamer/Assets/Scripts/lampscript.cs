using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
      var onoffcounterfloor = 0;
      var floorlight = GameObject.FindWithTag("Floorlight" );
      if (onoffcounterfloor%2 == 0) {
        floorlight.GetComponent<Light>().enabled = false;
      }
      else {
        floorlight.GetComponent<Light>().enabled = true;
      }
    }
}
