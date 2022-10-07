using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{


    [SerializeField] private Transform controladorDisparo;
    
    [SerializeField] private GameObject bala;
    [SerializeField] private GameObject balaArriba;    
     [SerializeField] private GameObject balaDiagonal;  

    private string balaDireccion;

   [Header("Animacion")]
    private Animator animator2;
    
    private Vector2 Direction;



    private void Start(){
       animator2 = GetComponent<Animator>();   
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

        animator2.SetTrigger("disparo"); 


        if(balaDireccion == "horizontal"){
        Disparar();
        }
      
        if(balaDireccion == "arriba"){
        DispararArriba();
        }

        if(balaDireccion == "diagonal"){
        DispararDiagonal();
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
