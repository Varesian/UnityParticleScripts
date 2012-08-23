using UnityEngine;
using System.Collections;

public class DuringCollisionEmitParticles : MonoBehaviour {
	
	public ParticleEmitter pe;
	
	// Use this for initialization
	void Start () {
		if (pe == null) {
			//see if there's a ParticleEmitter attached to the parent
				Debug.LogError("This script needs a reference to a ParticleEmitter object", this);
		}
	}
	
	void OnPointCloudCollisionEnter() {
		pe.emit = true;
	}

	void OnPointCloudCollisionExit() {
		pe.emit = false;
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
