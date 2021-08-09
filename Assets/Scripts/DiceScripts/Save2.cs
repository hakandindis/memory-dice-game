using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save2 : MonoBehaviour
{

    public Hakan[] hakans;
    public int[] colors;
    public int[] numbers;
    
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        InvokeRepeating("SaveColor", 1f, 0.1f);
        InvokeRepeating("SaveNumber", 1f, 0.1f);
    }

    
    public void SaveColor()
    {
        for (int i = 0; i < 6; i++)
        {
            if (hakans[i].indexColor == 0)
            {
                colors[i] = hakans[i].indexColor;
            }
            else
            {
                colors[i] = hakans[i].indexColor - 1;
            }
            
        }    
    }

    public void SaveNumber()
    {
        for (int i = 0; i < 6; i++)
        {
            if (hakans[i].indexNumber == 0)
            {
                numbers[i] = hakans[i].indexNumber;
            }
            else
            {
                numbers[i] = hakans[i].indexNumber - 1;
            }
        }
    }
    
}
