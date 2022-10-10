using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combate : MonoBehaviour
{
[SerializeField] int vida;
private diegardo movimientoJugador;
[SerializeField] private float tiempoPerdidaControl;
private Animator animator4;

private void Start(){
    movimientoJugador = GetComponent<diegardo>();
    animator4 = GetComponent<Animator>();
}



public void TomarDaño(int daño, Vector2 posicion){
    vida -= daño;
    animator4.SetTrigger("Golpe");
    StartCoroutine(PerderControl());
    movimientoJugador.Rebote(posicion);
    if(vida <= 0)
    {
        Destroy(gameObject);
    }    
}

private IEnumerator PerderControl(){
    movimientoJugador.sePuedeMover = false;
    yield return new WaitForSeconds(tiempoPerdidaControl);
    movimientoJugador.sePuedeMover = true;
}

}
