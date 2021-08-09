using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveProperties : MonoBehaviour
{
    public GameObject[] dices;
    public DiceProperties[] properties;
    public int[] colorArray;
    public int[] numberArray;

    // Start is called before the first frame update
    void Start()
    {
        properties[0] = dices[0].GetComponent<DiceProperties>();
        properties[1] = dices[1].GetComponent<DiceProperties>();
        properties[2] = dices[2].GetComponent<DiceProperties>();
        properties[3] = dices[3].GetComponent<DiceProperties>();
        properties[4] = dices[4].GetComponent<DiceProperties>();
        properties[5] = dices[5].GetComponent<DiceProperties>();

        DontDestroyOnLoad(this.gameObject);
        InvokeRepeating("UpdateProperties", 1.1f, 0.5f);
    }


    public void UpdateProperties()
    {
        UpdateColor();
        UpdateNumber();
    }

    public void UpdateColor()
    {
        for (int i = 0; i < 6; i++)
        {
            colorArray[i] = properties[i].indexColor;
        }
    }

    public void UpdateNumber()
    {
        for (int i = 0; i < 6; i++)
        {
            numberArray[i] = properties[i].indexNumber;
        }
    }


}
