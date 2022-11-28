using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject gameManager;//置放GameManager物件公開變數
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //點擊左方向紐時
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);//往左移動「3」
        }
        //點擊右方向紐時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);//往右移動「3」
        }

    }

    public void LbuttonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RbuttonDown()
    {
        transform.Translate(3, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.GetComponent<GameManager>().DecreaseHp();//扣血
        print("0");
    }
}
