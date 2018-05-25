using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeGazePointerColor : MonoBehaviour {

    public GameObject objectRenderMesh;
    public Renderer ren;
    public Material[] mat;

    public void ChangeTexture()
    {

        if (EventSystem.current.IsPointerOverGameObject())
            Debug.Log("Change of Texture");
        ren = objectRenderMesh.GetComponent<Renderer>();
        mat = ren.materials;
        mat[0].color = Color.red;
    }
}
