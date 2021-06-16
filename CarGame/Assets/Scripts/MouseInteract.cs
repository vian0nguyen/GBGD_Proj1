using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour
{
    public string clickingOn;

    //https://gamedevbeginner.com/how-to-convert-the-mouse-position-to-world-space-in-unity-2d-3d/#screen_to_world_3d
    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;

        //use this area to set up categories of items to be clicked on
        //REMEMBER: object needs to be tagged + spelled correctly (capsSensitive!)
        //probably needs a collider too
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hitData, 1000) && hitData.transform.tag == "Interactive")
            {
                clickingOn = "Interactive"; //sets the public string to be "interactive"!
                ClickObject clickedObject = hitData.transform.gameObject.GetComponent<ClickObject>();
                printObjectStats(clickedObject);

                Debug.Log("something Interactive");
            }

            if (Physics.Raycast(ray, out hitData, 1000) && hitData.transform.tag == "Object")
            {
                clickingOn = "Object";
                ClickObject clickedObject = hitData.transform.gameObject.GetComponent<ClickObject>();
                printObjectStats(clickedObject);

                Debug.Log("an Object");
            }

        }

        void printObjectStats(ClickObject clickObj)
        {
            print(clickObj.name);
            print(clickObj.objRenderer);
            clickObj.objRenderer.material.color = clickObj.objectColorChange; //changes object color

        }

    }
}
