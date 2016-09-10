using UnityEngine;
using System.Collections;

public class gunScript : MonoBehaviour {
    public int gunId;
    public int curAmmo;
    public int clipSize;
    public int clipAmmo;


    public int firerate;

    public int gunType;

    public int gunDmg;
    public int ProjectileSpeed;

    testShoot shootMaster;
    void Start()
    {
        shootMaster =GetComponentInParent <testShoot>();

        shootMaster.fireRate = firerate;
        shootMaster.gunType = gunType;
        shootMaster.projectileSpeed = ProjectileSpeed;
        shootMaster.wpndmg = gunDmg;

    }
}
