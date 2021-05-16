using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;
    [SerializeField]
    Transform target;
    [SerializeField]
    Transform GunPoint;
    [SerializeField]
    float atkCd;
    [SerializeField]
    float atkForce;
    [SerializeField]
    bool Aiming;
    [SerializeField]
    bool NormalGrava;

    float atkCDTimer =0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shootingProcess());
    }

    // Update is called once per frame
    void Update()
    {
        aim();
    }


    void aim()
    {
        if (Aiming)
            this.transform.up = target.position - this.transform.position;
        else
            this.transform.up = Vector2.down;
        
        if(NormalGrava)
        {
            this.transform.up = Vector2.left;
            atkForce = 150;

        }
    }

    void shoot()
    {
        GameObject a = Instantiate(bulletPrefab, GunPoint.transform.position, this.transform.rotation);
        Rigidbody2D rig = a.GetComponent<Rigidbody2D>();
        rig.AddForce(this.transform.up.normalized *atkForce);

    }
    IEnumerator shootingProcess()
    {
        while(true)
        {
            atkCDTimer += Time.deltaTime;
            if(atkCDTimer>=atkCd)
            {

                atkCDTimer = 0;
                shoot();
            }
            yield return new WaitForEndOfFrame();


        }



    }

}
