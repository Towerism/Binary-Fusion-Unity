using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyOffScreen : MonoBehaviour {

    public float screenWidth = 400;
    public float screenHeight = 800;

    public bool upperBoundary = true;
    public bool lowerBoundary = true;
    public bool leftBoundary = true;
    public bool rightBoundary = true;

	// Use this for initialization
	void Start () {
        _transform = transform;
    }
	
	// Update is called once per frame
	void Update () {
        if (_transform.position.x < 0 && leftBoundary)
            Destroy(gameObject);
        if (_transform.position.x > screenWidth && rightBoundary)
            Destroy(gameObject);
        if (_transform.position.y < 0 && lowerBoundary)
            Destroy(gameObject);
        if (_transform.position.y > screenHeight && upperBoundary)
            Destroy(gameObject);
	}

    Transform _transform;
}
