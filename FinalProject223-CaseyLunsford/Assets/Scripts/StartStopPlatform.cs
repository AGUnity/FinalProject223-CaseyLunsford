using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartStopPlatform : MonoBehaviour {

    public Animator TargetAnimator = null;

    public void OnTriggerEnter()
    {
        TargetAnimator.enabled = true;
    }
    public void OnTriggerExit()
    {
        TargetAnimator.enabled = false;
    }
}
