using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0; // 回転速度


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //　マウスが押されたら速度を10にする。
            this.rotSpeed = 10;
        }
        this.transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.96f;
    }

}
