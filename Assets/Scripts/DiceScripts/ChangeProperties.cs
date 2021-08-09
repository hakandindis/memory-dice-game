using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeProperties : MonoBehaviour
{
    public GameObject currentObject;
    public RaycastHit target;
    public Camera camera;
    //public Save2 save2;

    public int indexColor;
    public int indexNumber;
    
    public MeshRenderer meshRenderer;
    public Transform targetTransform;
    public Hakan hakan;

    public List<Quaternion> numbers;
    public List<Material> materials;

    // Start is called before the first frame update
    void Awake()
    {
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
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();        
    }

    // Update is called once per frame
    void Update()
    {
        //FindDice();
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
            meshRenderer = currentObject.GetComponent<MeshRenderer>();
            hakan = currentObject.GetComponent<Hakan>();
            this.indexColor = hakan.indexColor;

            indexColor %= 6; // sonradan eklendi
            
            meshRenderer.material = materials[this.indexColor];

            //sonradan eklendi
            //save2.colors[this.indexColor] = this.indexColor;
            
            indexColor++;

            hakan.indexColor = this.indexColor;
            //hakan.indexColor += 1;


            //indexColor %= 6; // silindi
            
        }
    }

    public void ChangeNumber()
    {
        FindDice();
        targetTransform = currentObject.GetComponent<Transform>();
        hakan = currentObject.GetComponent<Hakan>();
        this.indexNumber = hakan.indexNumber;


        indexNumber %= 6; // sonradan eklendi

        currentObject.transform.rotation = numbers[this.indexNumber];
        
        //save2.numbers[this.indexNumber] = this.indexNumber;
        
        indexNumber++;
        
        hakan.indexNumber = this.indexNumber;

        //indexNumber %= 6; // silindi
        
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
