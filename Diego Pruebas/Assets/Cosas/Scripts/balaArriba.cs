using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaArriba : MonoBehaviour
{
    // Start is called before the first frame update[SerializeField] private float velocidad;

[SerializeField] private float velocidad;
[SerializeField] private float daño;


    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
       
    }

        private void OnTriggerEnter2D(Collider2D other){
            if(other.CompareTag("Enemigo")){
                other.GetComponent<Enemigo>().TomarDaño(daño);
                Destroy(gameObject);
            }
        
        }
}
