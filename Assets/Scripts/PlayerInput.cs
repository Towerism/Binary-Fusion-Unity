using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class PlayerInput : MonoBehaviour {

    public float horizontalSpeed;
    public float verticalSpeed;
    public tk2dSpriteAnimator animator;
    public ColorController color;/*
    int color = 0;
    bool changingColor = false;*/

    Transform _transform;

	// Use this for initialization
	void Start () {
        gameObject.AutoCache<Transform>(ref _transform, transform);
	}
	
	// Update is called once per frame
	void Update () {
        movement();
        colorInput();
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
        /*if (Input.GetKeyDown(KeyCode.X) && !changingColor) {
            iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(0, 1, 0), "time", .25f, "oncomplete", "switchColor", "easetype", iTween.EaseType.linear));
            changingColor = true;
        }*/
    }

    /*void switchColor() {
        color = color == 0 ? 1 : 0;
        animator.SetFrame(color);
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(1, 1, 0), "time", .25f, "easetype", iTween.EaseType.linear, "oncomplete", "setChangingColorFalse"));
    }

    void setChangingColorFalse() {
        changingColor = false;
    }*/
}
