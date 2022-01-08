using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiff){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(5, Random.Range(-1.8f, 3.0f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}
