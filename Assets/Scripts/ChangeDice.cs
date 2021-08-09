using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDice : MonoBehaviour
{

    public GameObject currentObject;
    public RaycastHit target;
    public Camera camera;

    public DiceNumber diceNumber;

    public MeshRenderer renderer;
    public Material[] materials;

    public int indexColor=0;
    public int indexNumber = 0;


    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        diceNumber = new DiceNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            ChangeColor();
        }

        if (Input.GetMouseButtonDown(1))
        {
            ChangeNumber();
        }

    }


    public void ChangeColor()
    {
        FindDice();
        if (currentObject.CompareTag("Dice"))
        {
            renderer = currentObject.GetComponent<MeshRenderer>();
            renderer.material = materials[indexColor];
            indexColor++;
            indexColor %= 6;
        }
    }

    public void ChangeNumber()
    {
        FindDice();
        currentObject.transform.rotation = diceNumber.three;
        //Transform parentTransform = currentObject.GetComponentInParent<Transform>();
        //parentTransform.rotation = diceNumber.one;

        //currentObject.GetComponentInParent<Transform>().rotation = diceNumber.one;
    }

    public void FindDice()
    {
        Ray light = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(light, out target, 25.0f))
        {
            currentObject = target.collider.gameObject;
        }
    }
}


public class DiceNumber
{

    public Quaternion one;
    public Quaternion two;
    public Quaternion three;
    public Quaternion four;
    public Quaternion five;
    public Quaternion six;


    public DiceNumber()
    {
        one = Quaternion.Euler(0f,-90f,-90f);
        two = Quaternion.Euler(0f,-90f,0f);
        three = Quaternion.Euler(180f,0f,90f);
        four = Quaternion.Euler(0f,0f,90f);
        five = Quaternion.Euler(-90f,0f,90f);
        six = Quaternion.Euler(-90f,0f,0f);
    }

}