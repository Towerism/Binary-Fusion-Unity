using UnityEngine;
using System.Collections;

public class LinearVelocity : MonoBehaviour {

    public float speed;
    public float direction;

    public void Init(float dir, float spd) {
        if (initialized) return;
        float radDir = dir * Mathf.Deg2Rad;
        float u = Mathf.Cos(radDir) * spd;
        float v = Mathf.Sin(radDir) * spd;
        velocity.Set(u, v);
        initialized = true;
    }

	// Use this for initialization
	void Start () {
        _transform = transform;
        Init(direction, speed );
	}
	
	// Update is called once per frame
	void Update () {
        _transform.Translate(velocity * Time.deltaTime);
	}

    Transform _transform;
    Vector2 velocity;
    bool initialized = false;
}
