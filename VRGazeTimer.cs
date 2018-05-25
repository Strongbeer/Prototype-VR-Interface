using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class VRGazeTimer : MonoBehaviour
{
    public float GazeTime = 2f;
    private float Timer;

   // public GameObject PanelActive;
   // public GameObject PanelInactive;


    private bool GazedAt;

    void Start()
    {
        
    }

    void Update()
    {
        if (GazedAt)
        {
            //Debug.Log("GazedAt TRue");

            Timer += Time.deltaTime;

            if (Timer >= GazeTime)
            {
                GetComponent<Button>().onClick.Invoke();
                Timer = 0;
               // PanelActive.transform.localScale = new Vector3(0.10692F, 0.10692F, 0.10692F);
               // PanelInactive.transform.localScale = new Vector3(0, 0, 0);
            }
        }
    }


    public void PointerEnter()
    {
        //Debug.Log("Pointer Enter");

        GazedAt = true;
    }

    public void PointerExit()
    {
        //Debug.Log("Pointer Exit");

        GazedAt = false;
        Timer = 0;
    }

    public void PointerDown()
    {
        //Debug.Log("Pointer Down");
    }
}