using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret2 : MonoBehaviour
{
    [SerializeField]
    private Transform turrettip;

    [SerializeField]
    private GameObject peluru;

    private Vector2 lookDirection;
    private float lookAngle;

    void Update()
    {
        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) *Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        if (Input.GetKeyDown("space"))
        {
            FireBullet();
            Destroy(peluru, 01f);
        }
    }

    private void FireBullet()
    {
    GameObject firedBullet = Instantiate(peluru, turrettip.position, turrettip.rotation);
    firedBullet.GetComponent<Rigidbody2D>().velocity = turrettip.up * 10f;
}
}

