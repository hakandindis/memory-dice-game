using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastDiceSave : MonoBehaviour
{

    public GameObject[] dices;
    public Save2 save2;

    public List<Quaternion> numbers;
    public List<Material> materials;

    public Transform diceTransform;
    public MeshRenderer diceRenderer;

    // Start is called before the first frame update
    void Awake()
    {
        save2 = GameObject.Find("Save2").GetComponent<Save2>();

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

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AssignColor()
    {
        for (int i = 0; i < 6; i++)
        {
            diceRenderer = dices[i].GetComponent<MeshRenderer>();
            diceRenderer.material = materials[save2.colors[i]];
            
        }
    }

    public void AssignNumber()
    {
        for (int i = 0; i < 6; i++)
        {
            diceTransform = dices[i].GetComponent<Transform>();
            diceTransform.rotation = numbers[save2.numbers[i]];
        }
    }
}
