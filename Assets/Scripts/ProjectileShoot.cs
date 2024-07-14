using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject leserPref;
    private void Update()
    {
        Shoot();
    }
    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(leserPref, transform.position, Quaternion.identity);
        }
    }
}
