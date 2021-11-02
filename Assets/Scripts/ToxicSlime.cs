using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicSlime : MonoBehaviour
{
    public GameObject explosionEffect;
    private Vector3 storedposition;

    void Awake()
    {
        //storedposition = transform.position;
    }
    void OnTriggerEnter(Collider other)
    {
        Vector3 particleSpawnPoint = other.transform.position;
        Instantiate(explosionEffect, particleSpawnPoint, Quaternion.identity);

        //Destroy() is the base function for destroying components and objects in game.
        //You need to specify that you are reffering to a game object.
        //Destroy(this), for instance, will destory the component, not the object.
        //Destroy(this.gameObject) will destroy the object where this component
        Destroy(other.gameObject);
    }

    // Update is called once per frame
    void Update()  
    {
        //Vector3 local = transform.position;
        //local.x += 1f * Time.deltaTime;
        //transform.position = local;
        //if()
    }
}
