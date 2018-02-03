using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Balls : MonoBehaviour {

    public Rigidbody2D ballRB;
    public SpriteRenderer sr;

    public GameObject Ball;

    private string currentColor;

    public Color colorRed;
    public Color colorBlue;
    public Color colorPink;
    public Color colorGreen;

    public static int gameScore;
    public static int lastScore;
    public Text score;
    public Text highScore;

    public int count;

    public string CurrentColor
    {
        get
        {
            return currentColor;
        }

        set
        {
            currentColor = value;
        }
    }

    void LateUpdate()
    {
        if (gameScore < 15)
        {
            float constantSpeed = 0.00005f;
            float smoothingFactor = 3.0f;

            var cvel = ballRB.velocity;
            var tvel = cvel.normalized * constantSpeed;
            ballRB.velocity = Vector3.Lerp(cvel, tvel, Time.deltaTime * smoothingFactor);
        } else if(gameScore >= 15 && gameScore < 30)
        {
            float constantSpeed = 0.00005f;
            float smoothingFactor = 2.5f;

            var cvel = ballRB.velocity;
            var tvel = cvel.normalized * constantSpeed;
            ballRB.velocity = Vector3.Lerp(cvel, tvel, Time.deltaTime * smoothingFactor);
        } else if(gameScore >= 30 && gameScore < 50)
        {
            float constantSpeed = 0.00005f;
            float smoothingFactor = 2.0f;

            var cvel = ballRB.velocity;
            var tvel = cvel.normalized * constantSpeed;
            ballRB.velocity = Vector3.Lerp(cvel, tvel, Time.deltaTime * smoothingFactor);
        } else if(gameScore >= 50 && gameScore < 70)
        {
            float constantSpeed = 0.00005f;
            float smoothingFactor = 1.5f;

            var cvel = ballRB.velocity;
            var tvel = cvel.normalized * constantSpeed;
            ballRB.velocity = Vector3.Lerp(cvel, tvel, Time.deltaTime * smoothingFactor);
        }else if(gameScore >= 70)
        {
            float constantSpeed = 0.00005f;
            float smoothingFactor = 1.0f;

            var cvel = ballRB.velocity;
            var tvel = cvel.normalized * constantSpeed;
            ballRB.velocity = Vector3.Lerp(cvel, tvel, Time.deltaTime * smoothingFactor);
        }
    }

    void Start()
    {
        SetRandomColor();
        count = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
     
   public void SetRandomColor()
    {
        int index = Random.Range(0, 4);

        switch(index)
        {
            case 0:
                CurrentColor = "red";
                sr.color = colorRed;
                break;
            case 1:
                CurrentColor = "blue";
                sr.color = colorBlue;
                break;
            case 2:
                CurrentColor = "pink";
                sr.color = colorPink;
                break;
            case 3:
                CurrentColor = "green";
                sr.color = colorGreen;
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "turnUp")
        {
            ballRB.AddForce(transform.up * 100000000000000f);
        }

        else if (other.tag == CurrentColor)
        {
            gameScore++;
            lastScore++;
            score.text = gameScore.ToString();
            
            if (gameScore > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", gameScore);
                highScore.text = gameScore.ToString();
            }
        }
        else
        {
            PlayerPrefs.SetInt("LastScore", gameScore);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            //AdManager.Instance.ShowVideo();
            //AdManager.Instance.ShowBanner();
            gameScore = 0;
            count++;

            if (count == 10 || count == 20 || count == 30 || count == 40 || count == 50)
            {
                AdManager.Instance.ShowVideo();
            }
        }
    }
}
