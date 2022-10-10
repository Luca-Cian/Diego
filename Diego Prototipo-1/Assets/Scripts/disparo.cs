using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{


    [SerializeField] private Transform controladorDisparo;
    
    [SerializeField] private GameObject bala;
    [SerializeField] private GameObject balaArriba;    
     [SerializeField] private GameObject balaDiagonal;  

    
    [SerializeField] private float firerateDiego;
    private float nextfireDiego;    

    private string balaDireccion;

   [Header("Animacion")]
    private Animator animator3;
    
    private Vector2 Direction;



    private void Start(){
       animator3 = GetComponent<Animator>();   
    }


    void Update()
    {      

      if(Input.GetKey(KeyCode.UpArrow)){
        balaDireccion = "arriba";

        if(Input.GetKey(KeyCode.RightArrow)){
        balaDireccion = "diagonal";
      }
        if(Input.GetKey(KeyCode.LeftArrow)){
        balaDireccion = "diagonal";
      }      
      }
      else{
        balaDireccion = "horizontal";
      }

      if(Input.GetKeyDown(KeyCode.A) ){
        
        if(Time.time > nextfireDiego)
        {    

        animator3.SetTrigger("disparo"); 


        if(balaDireccion == "horizontal"){
        Disparar();
        }
      
        if(balaDireccion == "arriba"){
        DispararArriba();
        }

        if(balaDireccion == "diagonal"){
        DispararDiagonal();
        }       


            nextfireDiego = Time.time + firerateDiego;

        } 

       } 

                 
    }

    private void Disparar(){
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);     

    }
    private void DispararArriba(){
        Instantiate(balaArriba, controladorDisparo.position, controladorDisparo.rotation);     

    }
    private void DispararDiagonal(){
        Instantiate(balaDiagonal, controladorDisparo.position, controladorDisparo.rotation);     

    }

}
