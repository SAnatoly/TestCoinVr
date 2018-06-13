using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // предусматриваем наличие компанента у объекта
public class VrController : MonoBehaviour
{


    public Transform cam;
    public float speed = 3;
    public float toggleAngle = 45;

    Rigidbody body;

    bool isMooving;

    //gameController gameController;
    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>(); // получаем компанент типа rigidbody
                                          // gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<gameController>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /* if(cam.eulerAngles.x <= toggleAngle)
         {
             isMooving = true;
         }
         else
         {
             isMooving = false;
         }*/

        isMooving = cam.eulerAngles.x >= toggleAngle && cam.eulerAngles.x < 90;

        if (isMooving)
        {
            Vector3 forward = cam.TransformDirection(Vector3.forward); // определяем перед камеры
            body.velocity = forward * speed; // Меняем скорость в направление камеры
        }


    }

    /* void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.tag == "Enemy") // папроверяем объект столкновения на соответствие (если предмет коснулся объект с тегом Emeny)
         {
             Debug.Log("You die");
             //GetComponent<Renderer>().material.color = Color.red; // меняет цвет объекта
             //Time.timeScale = 0; // останавливает время
             gameController.Lose();
             enabled = false;
         }
     }
     void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "Finish") // папроверяем объект столкновения на соответствие (если предмет коснулся объект с тегом Emeny)
         {
             // Time.timeScale = 0; // останавливает время
             gameController.Win();
             enabled = false;
         }
     }*/
}
