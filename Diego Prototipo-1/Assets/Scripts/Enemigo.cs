using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{


    [SerializeField] private float vida;
     [SerializeField] private GameObject efectoMuerte;
         private Animator animator2;

    void Start(){
        animator2 = GetComponent<Animator>();
    }     

    public void TomarDaño(float daño)
    {
        vida -= daño;
        animator2.SetTrigger("DañoEnemigo");
        if (vida <= 0){
            Muerte();
        }
    }


       private void Muerte(){
        Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
       }
}
