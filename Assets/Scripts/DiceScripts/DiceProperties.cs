using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceProperties : MonoBehaviour
{
    public int indexColor;
    public int indexNumber;
    public int repeatCounter;
    
    public MeshRenderer meshRenderer;
    public Transform transform;


    public List<Quaternion> numbers;
    public List<Material> materials;

    // Start is called before the first frame update
    void Awake()
    {
        repeatCounter = 0;

        numbers.Add(Quaternion.Euler(0f, -90f, -90f));
        numbers.Add(Quaternion.Euler(0f, -90f, 0f));
        numbers.Add(Quaternion.Euler(180f, 0f, 90f));
        numbers.Add(Quaternion.Euler(0f, 0f, 90f));
        numbers.Add(Quaternion.Euler(-90f, 0f, 90f));
        numbers.Add(Quaternion.Euler(-90f, 0f, 0f));

        
    }
    private void Start()
    {
        InvokeRepeating("CallChangeFunctions", 1f, 1f);
        //InvokeRepeating("ChangeRandomColor", 1f, 1f);
        //InvokeRepeating("ChangeRandomNumber", 1f, 1f);

        //ChangeRandomNumber();
    }

    
    public void CallChangeFunctions()
    {
        if (repeatCounter < 9)
        {
            ChangeRandomColor();
            ChangeRandomNumber();
            repeatCounter++;
        }
    }

    public void ChangeRandomColor()
    {
        indexColor = Random.Range(0, 6);
        meshRenderer.material = materials[indexColor];
    }

    public void ChangeRandomNumber()
    {
        indexNumber = Random.Range(0, 6);
        transform.rotation = numbers[indexNumber];
    }

}
