using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TampilPartikel : MonoBehaviour
{
    public Transform Ledakan;
    // Start is called before the first frame update

        void OnCollisionEnter2D(Collision2D target){ //cek tabrakan tanpa is trigger
		if (target.gameObject.tag=="Obstacle"){ //jika tabrakan dgn Obstacle
		Instantiate(Ledakan, transform.position, Ledakan.rotation);
        
        //Ledakan.SetActive(true);
		}
    }
}

