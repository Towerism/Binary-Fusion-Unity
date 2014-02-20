using UnityEngine;
using System.Collections;

using ExtensionMethods;

public class EnemyBasicGun : AbstractGun {

	public override void Shoot () {
        GameObject go = createBullet();
        aimAtPlayer(ref go);
	}

	// Use this for initialization
	protected override void Start () {
        base.Start();
	}
	
	// Update is called once per frame
    void Update() {

    }

    void aimAtPlayer(ref GameObject go) {
        LinearVelocity vel = go.GetComponent<LinearVelocity>();
        Vector2 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 myPos = _transform.position;
        float angleToPlayer = Mathf.Atan2(playerPos.y - myPos.y, playerPos.x - myPos.x) * Mathf.Rad2Deg;
        vel.Init(angleToPlayer, 120);
    }
}
