using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaleMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;

    public int indx;
    public Vector3 tailTarget;
    public SnakeMove mainSnake;
    public GameObject TailTargetObject;
    void Start()
    {
       
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMove>();
        Speed = mainSnake.speed-0.5f;
        TailTargetObject = mainSnake.tallobject[mainSnake.tallobject.Count - 2];
        indx = mainSnake.tallobject.IndexOf(gameObject);
    }
    void Update()
    {
        tailTarget = TailTargetObject.transform.position; 
     
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("SnakeMain"))
        {
            if(indx>7)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

}
