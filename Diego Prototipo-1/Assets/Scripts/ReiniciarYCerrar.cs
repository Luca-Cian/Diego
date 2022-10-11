using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarYCerrar : MonoBehaviour
{



    void Update()
    {
      if(Input.GetKey(KeyCode.Escape)){
       Cerrar();    
      }       
      if(Input.GetKey(KeyCode.R)){
       Reiniciar();    
      }          
    }

    void Reiniciar(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Cerrar(){
        Application.Quit();
    }

}
