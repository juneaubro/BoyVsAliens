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

    void FixedUpdate()
    {
        ShootLazerPistol();
    }
    void ShootLazerPistol()
    {
        if(Items.GunAmount == 0)
        {
            Debug.Log("No ammo");
        }
        else if(shoot)
        {
            bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.Euler(bulletSpawn.transform.rotation.z, player.transform.rotation.y, cam.transform.rotation.x));
            bullet.transform.parent = null;
            bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletSpeed, ForceMode.Impulse);
            shoot = false;
            Items.GunAmount = Items.GunAmount - 1;
        }
    }

    public void shootbtn()
    {
        player = GameObject.Find("Player");
        cam = GameObject.Find("Main Camera");
        bulletSpawn = GameObject.Find("BulletSpawn").transform;
        shoot = true;
    }
}
