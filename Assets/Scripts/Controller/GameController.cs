using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JinGroupUnityBase.Base.Plane;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    // Start is called before the first frame update
    public GameObject ButtonReplay;
    public GameObject ButtonPlay;
    public GameObject chonqua1;
    public float scoreplayer;
    public float delay;
    public Text score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        Time.timeScale = 1;
        scoreplayer = 0;
    }

    private void OnEnable()
    {
        //dc goi moi khi dc active
        //StartCoroutine(BonusScore());
    }

    // Update is called once per frame
    void Update()
    {
        //EndGame();
        score.text = "  " + scoreplayer.ToString();
        Debug.Log("diem so");
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        ButtonPlay.SetActive(false);
        ButtonReplay.SetActive(true);
    }
    public void WinGame()
    {
        Time.timeScale = 0;
        chonqua1.SetActive(true);
    }
    public void BonusScore()
    {
        scoreplayer += 1;
    }
    public void OpenURLYouTube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=3AtDnEC4zak");
        //link chuyen hướng sang trang web nhận quà!!!!!!!!!!!
    }

}

