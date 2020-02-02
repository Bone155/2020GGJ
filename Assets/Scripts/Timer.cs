using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer;
    public GameObject playerReference;
    Movement move;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        move = playerReference.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + (int)timer;
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            text.text = "0";
            move.speed = 0;
            //SceneManager.LoadScene("Main");
        }
    }
}
