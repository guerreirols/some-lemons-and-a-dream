using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Animator playerAnimator;
    private float inputX;
    private float inputY;
    [SerializeField]
    private float speed = 2.5f;
    private bool isWalking = false;


    void Start()
    {
        isWalking = false;
    }

    void Update()
    {
        if(!Dialogue.inDialogue)
        {
            inputX = Input.GetAxisRaw("Horizontal");
            inputY = Input.GetAxisRaw("Vertical");
            isWalking = (inputX != 0 || inputY != 0);

            if (isWalking)
            {
                Vector3 move = new Vector3(inputX, inputY).normalized;
                transform.position += move * speed * Time.deltaTime;
                playerAnimator.SetFloat("input_x", inputX);
                playerAnimator.SetFloat("input_y", inputY);
            }

            playerAnimator.SetBool("isWalking", isWalking);

            if (Input.GetButtonDown("Fire1"))
            {
                playerAnimator.SetTrigger("attack");
            }
        }       
    }
}
