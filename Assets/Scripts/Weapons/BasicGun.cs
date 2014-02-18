using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class BasicGun : AbstractGun {

    public override void Shoot() {
        GameObject go = Instantiate(bulletPrefab, _transform.position, Quaternion.identity) as GameObject;
        go.SyncColor(gameObject);
        LinearVelocity lv = go.GetComponent<LinearVelocity>();
        lv.Init(new Vector2(0, 300));
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
