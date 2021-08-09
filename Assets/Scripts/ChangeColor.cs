using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject currentObject;
    public RaycastHit target;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetActiveDice();
        }
    }



    public void SetActiveDice()
    {

        Ray light = camera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(light,out target,25.0f))
        {
            currentObject = target.collider.gameObject;
            currentObject.transform.position = new Vector3(5f, 5f, 5f);
        }

    }



}
