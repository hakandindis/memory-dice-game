using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
[RequireComponent(typeof(AudioSource))]
public class TypeWriter : MonoBehaviour
{
    public float delay;
    public AudioClip typeSound;
    AudioSource audSrc;

    [Multiline]
    public string yazi;
    
    public TMP_Text mainText;

    //Text thisText;

    private void Start()
    {
        audSrc = GetComponent<AudioSource>();
        //thisText = GetComponent<Text>();

        StartCoroutine(TypeWrite());
    }


    IEnumerator TypeWrite()
    {
        foreach(char i in yazi)
        {
            mainText.text += i.ToString();

            audSrc.pitch = Random.Range(0.8f, 1.2f);
            audSrc.PlayOneShot(typeSound);

            if(i.ToString() == ".")
            {
                yield return new WaitForSeconds(1f);
            }

            else
            {
                yield return new WaitForSeconds(delay);
            }

        }
    }

}
