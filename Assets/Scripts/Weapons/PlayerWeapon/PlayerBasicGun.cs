using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class PlayerBasicGun : AbstractGun {

    public override void Shoot() {
        createBullet();
    }

    // Use this for initialization
    protected override void Start() {
        base.Start();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
