using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    [SerializeField] public Transform jugador;
    [SerializeField] private float distancia;
<<<<<<< Updated upstream
=======
    [SerializeField] float posInicialx;
>>>>>>> Stashed changes

    public Vector3 puntoInicial;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

<<<<<<< Updated upstream
    // Start is called before the first frame update
    void Start()
    {   animator = GetComponent<Animator>();
        puntoInicial= transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
=======
    [SerializeField] private int daño;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {   rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        puntoInicial= transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();

        
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        distancia = Vector2.Distance(transform.position,jugador.position);
        animator.SetFloat("Distancia",distancia);
    }

=======
        distancia = Vector2.Distance(new Vector2(transform.position.x,0),new Vector2(jugador.position.x,0));
        //distancia = (Mathf.Abs(jugador.position.x)-Mathf.Abs(transform.position.x));
        animator.SetFloat("Distancia",distancia);

        

    }

    private void OnCollisionEnter2D(Collision2D other){
            if(other.gameObject.CompareTag("Player")){
                other.gameObject.GetComponent<combate>().TomarDaño(daño, Vector2.right);
                
            }
        
        }
    

>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======

    
>>>>>>> Stashed changes
}
