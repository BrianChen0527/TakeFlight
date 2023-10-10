using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTriggerScript : MonoBehaviour
{
    public LogicScript scoreLogic;

    // Start is called before the first frame update
    void Start()
    {
        scoreLogic = GameObject.FindGameObjectWithTag("ScoreLogic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreLogic.AddScore();
    }
}
