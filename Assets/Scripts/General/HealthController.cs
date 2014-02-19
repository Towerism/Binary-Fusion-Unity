using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {

    public int startingHealth;

    public int Health {
        get {
            return health;
        }
    }

    public void Damage(int amount) {
        health -= amount;
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

    int health;
}