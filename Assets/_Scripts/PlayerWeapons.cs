using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed;

    private GameObject bullet;
    private bool shoot;
    private Transform bulletSpawn;
    private GameObject cam;
    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
        cam = GameObject.Find("Main Camera");
        bulletSpawn = GameObject.Find("BulletSpawn").transform;
    }

    void FixedUpdate()
    {
        ShootLazerPistol();
    }
    void ShootLazerPistol()
    {
        if (shoot)
        {
            bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.Euler(bulletSpawn.transform.rotation.z, player.transform.rotation.y, cam.transform.rotation.x));
            bullet.transform.parent = null;
            bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed, ForceMode.Impulse);
            shoot = false;
        }
    }

    public void shootbtn()
    {
        shoot = true;
    }
}
