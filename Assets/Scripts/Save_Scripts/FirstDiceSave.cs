using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDiceSave : MonoBehaviour
{
    public GameObject[] dices;
    public SaveProperties save;

    public List<Quaternion> numbers;
    public List<Material> materials;

    public Transform diceTransform;
    public MeshRenderer diceRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        save = GameObject.Find("Save").GetComponent<SaveProperties>();

        numbers.Add(Quaternion.Euler(0f, -90f, -90f));
        numbers.Add(Quaternion.Euler(0f, -90f, 0f));
        numbers.Add(Quaternion.Euler(180f, 0f, 90f));
        numbers.Add(Quaternion.Euler(0f, 0f, 90f));
        numbers.Add(Quaternion.Euler(-90f, 0f, 90f));
        numbers.Add(Quaternion.Euler(-90f, 0f, 0f));
    }

    // Start is called before the first frame update
    void Start()
    {
        AssignColor();
        AssignNumber();
    }


    public void AssignColor()
    {
        for (int i = 0; i < 6; i++)
        {
            diceRenderer = dices[i].GetComponent<MeshRenderer>();
            diceRenderer.material = materials[save.colorArray[i]];

        }
    }

    public void AssignNumber()
    {
        for (int i = 0; i < 6; i++)
        {
            diceTransform = dices[i].GetComponent<Transform>();
            diceTransform.rotation = numbers[save.numberArray[i]];
        }
    }



}
