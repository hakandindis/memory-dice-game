using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public Quaternion one;
    public Quaternion two;
    public Quaternion three;
    public Quaternion four;
    public Quaternion five;
    public Quaternion six;

    public List<Quaternion> numbers;

    public Material red;
    public Material green;
    public Material blue;
    public Material orange;
    public Material yellow;
    public Material purple;

    public List<Material> materials;

    public Dice()
    {
        one = Quaternion.Euler(0f, -90f, -90f);
        two = Quaternion.Euler(0f, -90f, 0f);
        three = Quaternion.Euler(180f, 0f, 90f);
        four = Quaternion.Euler(0f, 0f, 90f);
        five = Quaternion.Euler(-90f, 0f, 90f);
        six = Quaternion.Euler(-90f, 0f, 0f);

        numbers.Add(one);
        numbers.Add(two);
        numbers.Add(three);
        numbers.Add(four);
        numbers.Add(five);
        numbers.Add(six);

        materials.Add(red);
        materials.Add(green);
        materials.Add(blue);
        materials.Add(orange);
        materials.Add(yellow);
        materials.Add(purple);
    }
}


