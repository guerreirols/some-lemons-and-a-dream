using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WorldController : MonoBehaviour
{
    private bool gameOver;

    [SerializeField]
    private GameObject pauseCanvas;

    [SerializeField]
    private Image mood;
    [SerializeField]
    private GameObject closed;

    [SerializeField]
    private Sprite happy;
    [SerializeField]
    private Sprite angry;

    [SerializeField]
    private Text lemonadePrice;
    [SerializeField]
    private Text time;

    private int random;

    void Start()
    {
        StartCoroutine(SoldLemonade());
        StartCoroutine(Hungry());
        StartCoroutine(ClotheDesire());
    }

    void Update()
    {
        PlayerDemands.MoodSensor();

        if(PlayerDemands.GetPlayer().GetIsHappy())
        {
            mood.sprite = happy;
        }
        else
        {
            mood.sprite = angry;
        }

        lemonadePrice.text = "M$" + LemonadeStandDemands.GetLemonadeStand().GetLemonadeValue().ToString("N");
        time.text = LemonadeStandDemands.GetLemonadeStand().GetLemonadeSpeed() + " seconds";

        if(!LemonadeStandDemands.GetLemonadeStand().GetOpen())
        {
            closed.SetActive(true);
        }
        else
        {
            closed.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseCanvas.SetActive(true);
            Time.timeScale = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            Resume();
        }
    }

    IEnumerator SoldLemonade()
    {
        while(!gameOver)
        {
            yield return new WaitForSeconds(LemonadeStandDemands.GetLemonadeStand().GetLemonadeSpeed());
            if (LemonadeStandDemands.GetLemonadeStand().GetOpen())
            {
                if(PlayerDemands.GetPlayer().GetIsHappy())
                {
                    LemonadeStandDemands.Sale();
                }
                else
                {
                    random = Random.Range(1, 4);

                    if(random == 3)
                    {
                        LemonadeStandDemands.Sale();
                    }
                }
                
            }            
        }  
    }

    public void ResetWorld()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    IEnumerator Hungry()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(11f);
            PlayerDemands.Hungry();
        }
    }
    IEnumerator ClotheDesire()
    {
        while (!gameOver)
        {
            yield return new WaitForSeconds(13f);
            PlayerDemands.ClothesDesire();
        }
    }

}
