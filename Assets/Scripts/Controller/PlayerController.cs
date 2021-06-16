using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Button;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Button.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
    }
    public void Run()
    {
        this.transform.position += new Vector3(1, 2.5f, 0);
        this.transform.position += new Vector3(1, 0, 0);
       // Debug.Log(transform.position);
        Button.SetActive(false);
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
            GameController.instance.EndGame();
        }
        if (collision.gameObject.tag == "BonusScore")
        {
            GameController.instance.BonusScore();
            Debug.Log("vacham");
        }
        if (collision.gameObject.tag == "Ground")
        {
            Button.SetActive(true);
            // this.transform.position -= new Vector3(1, 0, 0) * Time.deltaTime * speed;
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
        if (collision.gameObject.tag == "WinGame")
        {
            GameController.instance.WinGame();
        }
    }
}
