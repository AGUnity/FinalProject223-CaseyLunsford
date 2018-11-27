using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {
    public GameObject prefab;
    public Animator TargetAnimator = null;
    public string TriggerName1 = string.Empty;
    public void OnTriggerEnter()
    {
        TargetAnimator.SetTrigger(TriggerName1);
        Instantiate(prefab, new Vector3(40, 20, 20), Quaternion.identity);
    }
}

