using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement2D : MonoBehaviour
{
    [Header("Movimiento")]
    [SerializeField] private float moveSpeed = 6f;

    private float DistanciaPorPaso = 1f;
    private bool Siestaenpasto;
    private float DistanciaAcumulada;

    private Vector2 UltimePose;
    private EncuentroSalvaje Encuentro;


    private Rigidbody2D rb;
    private float horizontalInput;
    private bool isGrounded;
    private int jumpsRemaining;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        UltimePose = rb.position;
        Encuentro = new EncuentroSalvaje(0.15f);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
        if (Siestaenpasto && rb.linearVelocity != Vector2.zero)
        {
            DistanciaAcumulada += Vector2.Distance(rb.position, UltimePose);
        }
        if (DistanciaAcumulada >= DistanciaPorPaso)
        {
            DistanciaAcumulada = 0f;
            if (Encuentro.IntentarEncuentro())
            {
                Debug.Log("Aparecio un pokemon salvaje bien salvaje: puede ser charizard o empoleon. Quien sabe");
                //int random = Random.Range(0, 2);
            }
 
        }
        UltimePose = rb.position;

    }
    

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Yuyito"))
        {
            Debug.Log ("Entraste al Yuyito");
            Siestaenpasto = true;

            

        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Yuyito"))
        {
            Debug.Log("Saliste del yuyito");
            Siestaenpasto = false;
            DistanciaAcumulada = 0f;

           
        }
    }

}