using UnityEngine;
using System.Collections;
using ExtensionMethods;

public class HealthController : MonoBehaviour {

    public float startingHealth = 1f;
    public float resistance = 0.5f;

    public float Health {
        get {
            return health;
        }
    }

    public void Damage(int amount, GameObject other) {
        float modifiedAmount = amount;
        if (gameObject.ColorEquals(other))
            modifiedAmount *= 1 - resistance;
        health -= modifiedAmount;
    }

    public void Heal(int amount) {
        health += amount;
    }

    public void Reset() {
        health = startingHealth;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    float health;
}