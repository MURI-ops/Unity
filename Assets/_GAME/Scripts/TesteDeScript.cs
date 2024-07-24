using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TesteDeScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Meu primeiro codigo");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(30, 0, 0);
    }
}
