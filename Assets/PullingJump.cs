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
            // ドラッグ開始位置（スクリーン空間の座標）を保存する
            clickPosition = Input.mousePosition;
        }   // マウス左ボタン(0)がプレス（押下）されたことを検出する
        else if (Input.GetMouseButtonUp(0))
        {
            // ドラッグと逆方向のベクトルを計算する
            Vector3 dragVector = clickPosition - Input.mousePosition;
            // ドラッグのベクトルの距離を求める
            float size = dragVector.magnitude;
            // ジャンプする
            rb.velocity = dragVector.normalized * jumpPower;
        }
    }
}