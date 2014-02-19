using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using ExtensionMethods;

public class DestroyOffScreen : MonoBehaviour {

    public bool upperBoundary = true;
    public bool lowerBoundary = true;
    public bool leftBoundary = true;
    public bool rightBoundary = true;

    public bool useSpriteBounds = true;
    public float xPadding = 0;
    public float yPadding = 0;

	// Use this for initialization
	void Start () {
        _transform = transform;
        if (useSpriteBounds) {
            xPadding = gameObject.halfSpriteWidth();
            yPadding = gameObject.halfSpriteHeight();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (_transform.position.x < 0 - xPadding && leftBoundary)
            Destroy(gameObject);
        if (_transform.position.x > camera.ActualWidth() + xPadding && rightBoundary)
            Destroy(gameObject);
        if (_transform.position.y < 0 - yPadding && lowerBoundary)
            Destroy(gameObject);
        if (_transform.position.y > camera.ActualHeight() + yPadding && upperBoundary)
            Destroy(gameObject);
	}

    Transform _transform;
}
