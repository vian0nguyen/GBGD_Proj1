using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour
{
    

    //TODO: set up a raycast mapped to mouse movement and be able to interact with objects
    //https://gamedevbeginner.com/how-to-convert-the-mouse-position-to-world-space-in-unity-2d-3d/#screen_to_world_3d
    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;


        if (Physics.Raycast(ray, out hitData, 1000) && hitData.transform.tag == "Interactive")
        {
            Debug.Log("something Interactive");
        }

        if (Physics.Raycast(ray, out hitData, 1000) && hitData.transform.tag == "Object")
        {
            Debug.Log("an Object");
        }
    }
}
