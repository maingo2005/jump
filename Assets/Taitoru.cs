using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Taitoru : MonoBehaviour
{

    public void LoadScene()
    {
        Debug.Log("test");
        SceneManager.LoadScene("SampleScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
