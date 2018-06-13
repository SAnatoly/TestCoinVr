using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VrInternetion : MonoBehaviour {

    public Camera VrCameta;
    public Image cursor;
    public float actionRate = 2; // как часто срабатывает взгляд
    float nextAction;
    public float multipleCursor = 3; // на сколько увиличиться курсор
    RectTransform cursorTransform; // компонент трансформации курсора
    Vector2 CursorSize; // стартовый размер курсора

	void Start ()
    {
        nextAction = actionRate;
        cursorTransform = cursor.GetComponent<RectTransform>(); // получаем компонент
        CursorSize = cursorTransform.sizeDelta; // сохраняем старотовый размер
	}
	
	void Update ()
    {
        Ray ray = VrCameta.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); // пускаем луч из центра камеры
        RaycastHit hit; // объект с которым столкнётся луч

        //пускае6м луч и проверяем объект пересечения
        if(Physics.Raycast(ray, out hit) && hit.transform.GetComponent<IVr>() != null)
        {
            //Debug.Log(hit.collider.gameObject.name);
            cursorTransform.sizeDelta += new Vector2(multipleCursor, multipleCursor) * Time.deltaTime;
            
            if(Time.time >= nextAction)
            {
                nextAction = Time.time + actionRate;
                //hit.collider.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value); 
                clearCursor();
                
                hit.transform.GetComponent<IVr>().OnReady();
            }
            

          /*  if( hit.collider.tag == "Spher")//&& Time.time >= nextAction)
            {
                //nextAction = Time.time + actionRate;
                hit.collider.GetComponent<Renderer>().material.color = new Color(1, 0, 1);
            }*/
        }

        else
        {

            nextAction = Time.time + actionRate;
            clearCursor();
        }
    }

    void clearCursor()
    {
        cursorTransform.sizeDelta = CursorSize;
    }

}
