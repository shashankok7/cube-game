using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float timestart = 0;
    public Transform player;
    void Update()
    {
        if (Input.GetKey("w")|| Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            timestart += Time.deltaTime;
            scoreText.text = timestart.ToString();
        }
       
    }
}
