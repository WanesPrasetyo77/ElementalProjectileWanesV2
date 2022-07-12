using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPrefab : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;

    int randomPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Change();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Change();
        }
        
    }

    void Change(){
        randomPrefab = Random.Range(0, 3);
        Instantiate(prefabs[randomPrefab]);
    }
}
