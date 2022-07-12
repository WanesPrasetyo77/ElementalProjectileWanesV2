using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewProjectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _speed;

    public void Init (Vector2 dir){
        _rb.velocity = dir * _speed;
    }

    void OnCollisionEnter3D(Collision2D col){
        col.transform.GetComponent<NewEnemy>().Die();

        Destroy(gameObject);
    }
}
