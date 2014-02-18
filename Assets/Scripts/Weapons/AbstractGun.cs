using UnityEngine;
using System.Collections;

abstract public class AbstractGun : MonoBehaviour {

    public GameObject bulletPrefab;

    abstract public void Shoot();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
