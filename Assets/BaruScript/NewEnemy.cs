using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _explodePrefab;

    // Update is called once per frame
    public void Die()
    {
        Instantiate(_explodePrefab, transform.position, Quaternion.Euler(90,0,0));
        Destroy(gameObject);        
    }
}
