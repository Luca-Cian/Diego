using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] public Transform jugador;
    [SerializeField] private float distancia;
    [SerializeField] float posInicialx;

    public Vector3 puntoInicial;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    [SerializeField] private int daño;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {   rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        puntoInicial= transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        distancia = Vector2.Distance(new Vector2(transform.position.x,0),new Vector2(jugador.position.x,0));
        //distancia = (Mathf.Abs(jugador.position.x)-Mathf.Abs(transform.position.x));
        animator.SetFloat("Distancia",distancia);

        

    }

    private void OnCollisionEnter2D(Collision2D other){
            if(other.gameObject.CompareTag("Player")){
                other.gameObject.GetComponent<combate>().TomarDaño(daño, Vector2.right);
                
            }
        
        }
    

    public void Girar(Vector3 objetivo)
    {
        if (transform.position.x < objetivo.x)
        {
             spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    
}
