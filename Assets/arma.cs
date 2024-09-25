using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{
    public GameObject projetil;
    public float launchForce;
    public Transform shotPoint;

    void Update()
    {
        Vector2 armaPosicao = transform.position;
        Vector2 mousePosicao = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direcao = mousePosicao - armaPosicao;
        transform.right = direcao;

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot(){
        GameObject newProj = Instantiate(projetil, shotPoint.position, shotPoint.rotation);
        newProj.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
    }
}
