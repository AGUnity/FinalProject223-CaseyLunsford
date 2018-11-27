using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    public Renderer objectRender = null;
	public void OnTriggerEnter () {
        objectRender = GetComponent<Renderer>();
        objectRender.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
