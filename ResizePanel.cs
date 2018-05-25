using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizePanel : MonoBehaviour {

    // Use this for initialization

    public GameObject Object;
    public GameObject Object2;

    // Update is called once per frame
    public void Scale ()
    {
        Object.transform.localScale += new Vector3(0.10692F, 0.10692F, 0.10692F);
        Object2.transform.localScale = new Vector3(0, 0, 0);
    }

    void Start () {
		
	}
}
