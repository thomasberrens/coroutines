using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f")) 
        {
            StartCoroutine(Check());
        }
    }

    IEnumerator Check()
    {
        Debug.Log("Ik start nu de coroutine");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + ". Coroutine update");
            yield return new WaitForSeconds(0.5f);
        }
        
        Debug.Log("coroutine einde");
    }
}
