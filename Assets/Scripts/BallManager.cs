using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class BallManager : MonoBehaviour
{
    public static BallManager ballManagerInstance;
    //public TextMeshProUGUI text;
    public int totalBallsOnLevel;
    public string nextLevel;
    private int balls;

    // Start is called before the first frame update
    void Start()
    {
        if(ballManagerInstance == null)
        {
            ballManagerInstance = this;
        }
    }

    public void ChangeBall(int ballAmount)
    {
        balls += ballAmount;
        //text.text = balls.ToString();
    }

    public void Update()
    {
        if (balls == totalBallsOnLevel)
        {
            MenuController.instance.LoadScene(nextLevel);
        }
    }
}
