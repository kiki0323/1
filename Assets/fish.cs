using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fish : MonoBehaviour
{
    GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);//3���R���ۤv
        gameManager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);//�I�즳�I���骺�F��N�R���ۤv

        if (collision.name == "player")
            gameManager.GetComponent<GameManager>().addhp();//����
    }
}
