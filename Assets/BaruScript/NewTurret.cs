using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTurret : MonoBehaviour
{
    private Camera _cam;
    [SerializeField,Range(1,100)] private float _rotationSpeed = 1;
    //[SerializeField] public NewProjectile _projectilePrefab; 
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] public NewProjectile[] _projectilePrefab;

    int randomPrefab;

    void Awake()
    {
        _cam = Camera.main;
    }
    void Start()
    {
        Change();
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        var dir = mousePosition - transform.position;
        transform.up = Vector3.MoveTowards(transform.up, dir, _rotationSpeed * Time.deltaTime);

        

        if (Input.GetKeyDown("space")){
                Instantiate(_projectilePrefab[randomPrefab], _spawnPoint.position, Quaternion.identity).Init(transform.up);
            //var clone_projectilePrefab = Instantiate(_projectilePrefab);
            //Destroy(gameObject, _projectilePrefab);
        }
        if(Input.GetMouseButtonDown(0)){
            Change();
        }
    }
    void Change(){
        randomPrefab = Random.Range(0, 3);
        Instantiate(_projectilePrefab[randomPrefab], _spawnPoint.position, Quaternion.identity).Init(transform.up);
    }

}

