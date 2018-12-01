using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRolling : MonoBehaviour {

    public Animator TargetAnimator = null;

    public void OnTriggerEnter()
    {
        TargetAnimator.enabled = true;
    }
}
