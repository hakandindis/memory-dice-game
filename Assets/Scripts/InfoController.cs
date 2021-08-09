using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoController : MonoBehaviour
{
    public List<Hakan> objects;
    public SaveProperties save;

    public GameObject panel;

    public Save2 save2;

    // Start is called before the first frame update
    void Start()
    {
        save = GameObject.Find("Save").GetComponent<SaveProperties>();
    }

    // Update is called once per frame
    void Update()
    {

        if(ControlColors() && ControlNumbers())
        {
            panel.SetActive(true);
        }
        
    }

    public bool ControlColors()
    {
        bool value=true;
        for (int i = 0; i < 6; i++)
        {

            if (objects[i].indexColor == 0)
            {
                if ((objects[i].indexColor) != save.colorArray[i])
                {
                    value = false;
                }
            }

            else if ((objects[i].indexColor - 1 ) != save.colorArray[i])
            {
                value = false;
            }
        }

        return value;
    }

    public bool ControlNumbers()
    {
        bool value = true;
        for (int i = 0; i < 6; i++)
        {

            if (objects[i].indexNumber == 0)
            {
                if ((objects[i].indexNumber) != save.numberArray[i])
                {
                    value = false;
                }
            }

            else if ((objects[i].indexNumber - 1 ) != save.numberArray[i])
            {
                value = false;
            }
        }

        return value;
    }

}
