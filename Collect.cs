using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public Text ScoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="black"){
            score --;
            ScoreText.text=score.ToString();
            other.gameObject.SetActive(false);

        }
        if(other.gameObject.tag=="white"){
            score ++;
             ScoreText.text=score.ToString();
            other.gameObject.SetActive(false);
         
        }
    }
}
