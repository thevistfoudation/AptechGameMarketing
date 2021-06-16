using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class CheckCollison : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
            GameController.instance.WinGame();
            Debug.Log("het game");
            }
            if (collision.gameObject.tag == " ")
            {
                Destroy(gameObject);
            }
        }
    }
    // điều kiện dùng đối tượng có compoment Boxcollider 2D đã bật Is Trigger

