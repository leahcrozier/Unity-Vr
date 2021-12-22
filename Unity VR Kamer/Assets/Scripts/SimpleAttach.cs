using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

//public class SimpleAttach : MonoBehaviour
//{
//    private Interactable interactable; 
//    // Start is called before the first frame update
//    void Start()
//    {
//        interactable = GetComponent<interactable>();
//    }

//    private void OnHandHoverBegin(Hand hand)
//    {
       
//    }

//    private void OnHandHoverEnd(Hand hand)
//    {
     
//    }

//    private void HandHoverUpdate(Hand hand)
//    {
//        GrabTypes grabtype = hand.GetGrabStarting();
//        bool isGrabEnding = hand.IsGrabEnding(this.gameObject);

//        if (interactable.attachedToHand == null && grabtype != GrabTypes.None)
//        {
//            hand.AttachObject(gameObject, grabType);
//            hand.HoverLock(interactable);

//        }
//        else if(isGrabEnding)
//        {
//            hand.DetatchObject(gameObject);
//            hand.HoverUnlock(interactable);
//        }
//    }
//}
