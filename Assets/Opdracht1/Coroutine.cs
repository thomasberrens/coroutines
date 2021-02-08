using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{

    [SerializeField] private float shadeTime = 0.2f;
    
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

        if (Input.GetKeyDown("c"))
        {
            StartCoroutine(Fade());
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

    IEnumerator Fade()
    {
        Debug.Log("Begin shading");
        for (float ft = 1f; ft >= 0; ft -= 0.1f) 
        {
            
            Color c = GetComponent<Renderer>().material.color;
            c.a = ft;
            GetComponent<Renderer>().material.color = c;
            
            Debug.Log("UPDATE");
            yield return new WaitForSeconds(shadeTime);
        }
        Debug.Log("End of shade");
    }
}
