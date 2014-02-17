using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class PlayerInput : MonoBehaviour {

    public float horizontalSpeed;
    public float verticalSpeed;
    public tk2dSpriteAnimator animator;
    public ColorController color;
    public BasicGun gun;

    Transform _transform;

	// Use this for initialization
	void Start () {
        _transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        movement();
        colorInput();
        shootInput();
	}

    void movement() {
        Vector2 hmove = Vector2.right * Input.GetAxis("Horizontal");
        Vector2 vmove = Vector2.up * Input.GetAxis("Vertical");
        _transform.Translate(hmove * horizontalSpeed);
        _transform.Translate(vmove * verticalSpeed);
    }

    void colorInput() {
        if (Input.GetKeyDown(KeyCode.X)) {
            color.SwitchColor();
        }
    }

    void shootInput() {
        if (Input.GetKeyDown(KeyCode.Z)) gun.Shoot();
    }
}
