using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJump : MonoBehaviour
{
    [SerializeField] float jumpPower = 10f;
    Rigidbody rb;
    Vector3 clickPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // �h���b�O�J�n�ʒu�i�X�N���[����Ԃ̍��W�j��ۑ�����
            clickPosition = Input.mousePosition;
        }   // �}�E�X���{�^��(0)���v���X�i�����j���ꂽ���Ƃ����o����
        else if (Input.GetMouseButtonUp(0))
        {
            // �h���b�O�Ƌt�����̃x�N�g�����v�Z����
            Vector3 dragVector = clickPosition - Input.mousePosition;
            // �h���b�O�̃x�N�g���̋��������߂�
            float size = dragVector.magnitude;
            // �W�����v����
            rb.velocity = dragVector.normalized * jumpPower;
        }
    }
}