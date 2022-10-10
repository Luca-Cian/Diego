using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaEnemigo : MonoBehaviour
{

[SerializeField] private float velocidad;

[SerializeField] private int daño;





    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
       
    }

        private void OnTriggerEnter2D(Collider2D other){
            if(other.CompareTag("Player")){
                other.GetComponent<combate>().TomarDaño(daño, Vector2.right);
                Destroy(gameObject);
                
            }
        
        }




}
