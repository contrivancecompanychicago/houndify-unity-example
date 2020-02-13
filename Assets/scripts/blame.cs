using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blame : MonoBehaviour
{
    // Start is called before the first frame update
    public static string guilt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerDown()
    {
        Debug.Log("test");
        Debug.Log(guilt);

        if(guilt == "Bob"){
            SceneManager.LoadScene("man");
            Debug.Log("Bob");
        }
        if(guilt =="Anna"){
            SceneManager.LoadScene("woman");
            Debug.Log("Anna");
        }

    }
}
