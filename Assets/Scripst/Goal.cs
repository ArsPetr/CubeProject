using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Text text;
    public Collider ball;
    private int c = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score:" + c;
    }
    private void OnTriggerEnter(Object b)
    {
       if (b == ball) c++;
    }
}
