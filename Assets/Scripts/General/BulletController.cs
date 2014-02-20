using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public float DamageValue {
        get {
            return damageValue;
        }
        set {
            damageValue = value;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    float damageValue;
}
