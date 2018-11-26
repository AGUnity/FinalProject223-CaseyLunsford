using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public void OnTriggerEnter()
    {
        GameObject Prefab = Instantiate(Prefab, transform.position) ;
    }
}

