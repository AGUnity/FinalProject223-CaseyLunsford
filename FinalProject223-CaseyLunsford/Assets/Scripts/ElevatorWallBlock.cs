using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorWallBlock : MonoBehaviour {

    public Animator TargetAnimator = null;
    public string TriggerName1 = string.Empty;
    public string TriggerName2 = string.Empty;

    void OnTriggerEnter(Collider Col)
    {
        TargetAnimator.SetTrigger(TriggerName1);
    }
    private void OnTriggerExit(Collider Col)
    {
        TargetAnimator.SetTrigger(TriggerName2);
    }
}
