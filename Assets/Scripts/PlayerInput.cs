using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class PlayerInput : MonoBehaviour {

    public float horizontalSpeed;
    public float verticalSpeed;

    Transform _transform;

	// Use this for initialization
	void Start () {
        gameObject.AutoCache<Transform>(ref _transform, transform);
	}
	
	// Update is called once per frame
	void Update () {
        movement();
	}

    void movement() {
        Vector2 hmove = Vector2.right * Input.GetAxis("Horizontal");
        Vector2 vmove = Vector2.up * Input.GetAxis("Vertical");
        _transform.Translate(hmove * horizontalSpeed);
        _transform.Translate(vmove * verticalSpeed);
    }
}
