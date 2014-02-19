using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class PlayerInput : MonoBehaviour {

    public float horizontalSpeed;
    public float verticalSpeed;
    public tk2dSpriteAnimator animator;
    public ColorController color;
    public AbstractGun gun;

	// Use this for initialization
	void Start () {
        _transform = transform;
        _camera = tk2dCamera.Instance;
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
        //if ((hmove.x < 0 && _transform.position.x < 50) ||
       //     (hmove.x > 0 && _transform.position.x > _camera.NativeResolution.x - 50)) return;
        _transform.Translate(hmove * horizontalSpeed);
       // if ((vmove.y < 0 && _transform.position.y < 50) ||
        //    (vmove.y > 0 && _transform.position.y > _camera.NativeResolution.y - 50)) return;
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

    Transform _transform;
    tk2dCamera _camera;
}
