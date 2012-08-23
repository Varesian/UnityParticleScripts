using UnityEngine;
using System.Collections;

public class DuringCollisionEmitParticles : MonoBehaviour {
	
	public ParticleEmitter pe;
	
	// Use this for initialization
	void Start () {
		if (pe == null) {
			Debug.LogError("This script needs a reference to a ParticleEmitter object", this);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseOver() {
		renderer.material.color = Color.red;
		pe.emit = true;
	}
	void OnMouseExit() {
		renderer.material.color = Color.black;
		pe.emit = false;
	}
}
