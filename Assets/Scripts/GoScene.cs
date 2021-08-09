using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("UploadNextScene", 17f);
    }



    public void UploadNextScene()
    {
        SceneManager.LoadScene(2);
    }


    public void xxxxx()
    {

    }
}
