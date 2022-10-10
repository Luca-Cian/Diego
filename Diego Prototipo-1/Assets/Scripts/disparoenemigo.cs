using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoenemigo : MonoBehaviour
{


    [SerializeField] private Transform controladorDisparo;
    
    [SerializeField] private GameObject balaEnemigo;

    private string balaDireccion;
   [SerializeField] private float firerate;
    private float nextfire;

   [Header("Animacion")]
   private Animator animator5;
    
    private Vector2 Direction;



    private void Start(){
    animator5 = GetComponent<Animator>();   
    }


    void Update()
    {      

        if(Time.time > nextfire)
        {
            nextfire = Time.time + firerate;
            Disparar();
        }

    }
    private void Disparar(){
        Instantiate(balaEnemigo, controladorDisparo.position, controladorDisparo.rotation);     
        animator5.SetTrigger("disparoEnemigo"); 
    }    

}
