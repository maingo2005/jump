using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class animesyun : MonoBehaviour
{
    Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            _anim.Play("idor");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            _anim.Play("Get");
        }
    }
}
