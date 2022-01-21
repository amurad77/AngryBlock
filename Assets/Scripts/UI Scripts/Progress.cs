using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{

    public RectTransform extraBallInner;

    private GameController gameController;

    private float currentWidth, addWidth, totalWidth;

    void Awake()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    void Start()
    {
        extraBallInner.sizeDelta = new Vector2(8, 117);
        currentWidth = 8;
        totalWidth = 400;
    }


    void Update()
    {
        if(currentWidth >= totalWidth)
        {
            gameController.ballsCount++;
            gameController.ballsCountText.text = gameController.ballsCount.ToString();
            currentWidth = 8;
        }

        if(currentWidth > addWidth)
        {
            addWidth += 5;
            extraBallInner.sizeDelta = new Vector2(addWidth, 117);
        }

        else
            addWidth = currentWidth;

    }


    public void IncreaseCurrentWidth()
    {
        int addRandom = Random.Range(80, 120);
        currentWidth = addRandom + 8 + currentWidth % 576f;
    }
}
