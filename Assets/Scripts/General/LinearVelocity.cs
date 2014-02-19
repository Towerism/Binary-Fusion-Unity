using UnityEngine;
using System.Collections;

public class LinearVelocity : MonoBehaviour {

    public Vector2 velocity;

	// Use this for initialization
	void Start () {
        _transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        _transform.Translate(velocity * Time.deltaTime);
	}

    Transform _transform;
}
