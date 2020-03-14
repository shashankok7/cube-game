using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float timestart = 0;
    public Transform player;
    void Update()
    {
        
        
            timestart += Time.deltaTime;
            scoreText.text = timestart.ToString("F2");
       
       
    }
}
