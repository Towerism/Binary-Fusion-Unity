using UnityEngine;
using System.Collections;

enum BinaryColor {
    White, Black
}

public class ColorController : MonoBehaviour {

    BinaryColor Color {
        get {
            if (color == white) return BinaryColor.White;
            else return BinaryColor.Black;
        }
    }

    public int white = 0;
    public int black = 1;

    public tk2dSpriteAnimator animator;

    bool changingColor = false;
    int color; 

    public void SwitchColor() {
        if (changingColor) return;
        animate();
    }

	// Use this for initialization
	void Start () {
        iTween.Init(gameObject);
        color = white;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void animate() {
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(0, 1, 0), "time", .25f, "oncomplete", "animateCallback", "easetype", iTween.EaseType.linear));
        changingColor = true;
    }

    void animateCallback() {
        color = color == black ? white : black;
        animator.SetFrame(color);
        iTween.ScaleTo(gameObject, iTween.Hash("scale", new Vector3(1, 1, 0), "time", .25f, "easetype", iTween.EaseType.linear, "oncomplete", "setChangingColorFalse"));
    }

    void setChangingColorFalse() {
        changingColor = false;
    }
}
