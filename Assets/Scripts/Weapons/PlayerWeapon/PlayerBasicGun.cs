using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class PlayerBasicGun : AbstractGun {

    public override void Shoot() {
        GameObject go = Instantiate(bulletPrefab, _transform.position, Quaternion.identity) as GameObject;
        go.SyncColor(gameObject);
    }

	// Use this for initialization
    void Start() {
        _transform = transform;
    }
	// Update is called once per frame
	void Update () {
	
	}

    Transform _transform;
}
