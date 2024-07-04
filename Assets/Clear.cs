using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;
    Animator _anim;

    public void LoadScene()
    {
        Debug.Log("test");
        SceneManager.LoadScene("Title");
    }

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _anim.SetBool("isGet", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (_anim.SetBool("isGet", true))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
