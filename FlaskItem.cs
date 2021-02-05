using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlaskItem : MonoBehaviour
{
    Transform flask_transform;
    public GameObject text;
    Transform text_transform;
    MeshRenderer display;
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        flask_transform = GetComponent<Transform>();
        display = GetComponent<MeshRenderer>();
        text_transform = text.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        score = score + 1;
        print(score);
        display.enabled = false;
        Destroy(text);
        gameObject.SetActive(false);
        if(score == 4)
        {
            SceneManager.LoadScene("scene2");
        };
    }
}
