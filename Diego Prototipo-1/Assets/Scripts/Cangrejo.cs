using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cangrejo : MonoBehaviour
{


private void OnCollisionEnter2D(Collision2D other){
if(other.gameObject.CompareTag("Player")){
   other.gameObject.GetComponent<combate>().TomarDaño(1, other.GetContact(0).normal);
}
}
}


