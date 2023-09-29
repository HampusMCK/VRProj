using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    [SerializeField]
    GameObject BulletPrefab;

    [SerializeField]
    Transform bulletSpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PullTrigger()
    {
       Instantiate(BulletPrefab, bulletSpawnPos.position, bulletSpawnPos.rotation);
    }
}
