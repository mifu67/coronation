using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance;
    [SerializeField] private float movementSpeed = 20f;
    private Rigidbody2D rb;
    public float jumpAmount = 8;
    private bool jumpPressed = false;
    private float playerInput = 0;
    Vector2 inputVector;
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        // Nothing for now
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            jumpPressed = true;
        }
    }

    void FixedUpdate()
    {
        if (jumpPressed)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            jumpPressed = false;
        }
        rb.velocity = rb.velocity + new Vector2(playerInput * Time.fixedDeltaTime * movementSpeed, 0);
    }

    // private void setPlayerPosition(float x, float y)
    // {
    //     transform.position = new Vector3(x, y, 0.0f);
    // }
}
