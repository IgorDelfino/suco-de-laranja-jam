using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    //Vetores de movimentação
    private Vector2 moveVelocity;
    private Vector2 moveInput;

    private Vector2 lastDirection;

    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GetInput();

        Animate();

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

    }

    //Função para pegar o input do usuário
    void GetInput()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        if ((moveX == 0 && moveY == 0) && moveInput.x != 0 || moveInput.y != 0)
        {
            lastDirection = moveInput;
        }

        moveInput = new Vector2(moveX, moveY);//coleta os valores direcionais
        moveVelocity = moveInput.normalized * speed;//multiplica pelo valor de velocidade
    }

    //Função para animações
    void Animate()
    {
        animator.SetFloat("HorizontalMovement", moveInput.x);
        animator.SetFloat("VerticalMovement", moveInput.y);
        animator.SetFloat("Magnitude", moveInput.magnitude);

        animator.SetFloat("LastMoveX", lastDirection.x);
        animator.SetFloat("LastMoveY", lastDirection.y);
    }

}
