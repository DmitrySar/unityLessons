using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ladder"))
        {
            //отключение физики у объекта
            rb.bodyType = RigidbodyType2D.Kinematic;
            //обработка перемещения вверх, вниз
            float axisY = Input.GetAxis("Vertical");
            if (axisY != 0)
            {
                transform.Translate(Vector3.up * axisY * PlayerConfig.speed * Time.deltaTime);
                PlayerController.getPlayer().setCurrentAnimationIndex(PlayerConfig.ON_LADDER_MOVE);
            } 
            else
            {
                PlayerController.getPlayer().setCurrentAnimationIndex(PlayerConfig.ON_LADDER);
            }
            
        }    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        PlayerController.getPlayer().setCurrentAnimationIndex(PlayerConfig.STAND_INDEX);
    }
}
