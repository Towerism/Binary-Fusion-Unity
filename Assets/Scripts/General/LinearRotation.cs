using UnityEngine;
using System.Collections;

public class LinearRotation : MonoBehaviour {

    public float rotationSpeed = 360f;

	// Use this for initialization
	void Start () {
        _transform = transform;	
	}
	
	// Update is called once per frame
    void Update() {
        _transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    }
    Transform _transform;

}
