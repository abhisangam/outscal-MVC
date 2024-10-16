using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private ParticleSystem detonationEffect;
    [SerializeField] private ParticleSystem smokeTrail;

    public void SetInitialVelocity(Vector3 velocity)
    {
        //smokeTrail.Play();
        GetComponent<Rigidbody>().velocity = velocity;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<TankView>() != null)
            return;

        Debug.Log(other.gameObject.name);
        ParticleSystem particle = GameObject.Instantiate(detonationEffect, gameObject.transform);
        particle.transform.parent = transform.parent;
        particle.transform.position = transform.position;
        GameObject.Destroy(gameObject);
    }
}
