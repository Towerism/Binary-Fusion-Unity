using UnityEngine;
using System.Collections;
using ExtensionMethods;

abstract public class AbstractGun : MonoBehaviour {

    public GameObject bulletPrefab;
    public float damageValue;

    abstract public void Shoot();

	// Use this for initialization
	protected virtual void Start () {
        _transform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    protected GameObject createBullet() {
        GameObject go = Instantiate(bulletPrefab, _transform.position, Quaternion.identity) as GameObject;
        BulletController bullet = go.GetComponent<BulletController>();
        bullet.DamageValue = damageValue;
        go.SyncColor(gameObject);
        return go;
    }

    protected Transform _transform;
    //protected Transform _transform;
}
