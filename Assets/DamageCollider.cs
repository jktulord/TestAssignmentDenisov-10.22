
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    /*
    public string name;
    public int damage;
    public string targetTag;
    public bool OnTriggerEnabled;
    public bool OnColliderEnabled;
    public bool Homing;
    public Vector3 TargetPosition;
    public bool DisappearOnCollide;

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(name+" Trigger Entered");
        if (!OnTriggerEnabled)
            return;
        DoEffect(other.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log(name+" Collider Entered");
        if (!OnColliderEnabled)
            return;
        DoEffect(collision.gameObject);
    }

    private void DoEffect(GameObject other){
        if (other.tag == targetTag)
        {
            Debug.Log(name+" "+damage+"dmg");
            TextSpawner.SpawnText(transform.position, ""+damage);
            other.GetComponent<Health>().GetDamaged(damage);
            if (DisappearOnCollide)
                Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Homing)
        {
            Vector2 distance = TargetPosition - transform.position;
            if (distance.magnitude < 0.3)
                Destroy(gameObject);
        }
    }
    */
}
