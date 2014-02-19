using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class ClampSpriteWithinCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        _transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        GameObject go = gameObject;
        _transform.position = new Vector3(
            Mathf.Clamp(_transform.position.x, go.halfSpriteWidth(), camera.ActualWidth() - go.halfSpriteWidth()),
            Mathf.Clamp(_transform.position.y, go.halfSpriteHeight(), camera.ActualHeight() - go.halfSpriteHeight()),
            _transform.position.z);
	}

    Transform _transform;
}
