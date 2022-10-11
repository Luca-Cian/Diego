using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combate : MonoBehaviour
{
[SerializeField] public int vida;
private diegardo movimientoJugador;
[SerializeField] private float tiempoPerdidaControl;
private Animator animator4;
[SerializeField] private GameObject efectoMuerte;

   private AudioSource audioSource;   
   [SerializeField] private AudioClip Impacto;

private void Start(){
    movimientoJugador = GetComponent<diegardo>();
    animator4 = GetComponent<Animator>();
    audioSource = GetComponent<AudioSource>();    
}



public void TomarDaño(int daño, Vector2 posicion){
    vida -= daño;
    animator4.SetTrigger("Golpe");
    StartCoroutine(PerderControl());
    movimientoJugador.Rebote(posicion);
    audioSource.PlayOneShot(Impacto);    
    if(vida <= 0)
    {
        Destroy(gameObject);
        Instantiate(efectoMuerte, transform.position, Quaternion.identity);        
    }    
}

private IEnumerator PerderControl(){
    movimientoJugador.sePuedeMover = false;
    yield return new WaitForSeconds(tiempoPerdidaControl);
    movimientoJugador.sePuedeMover = true;
}

}
