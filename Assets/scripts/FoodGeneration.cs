using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float xSize = 18;
    public float zSize = 18;
    public GameObject foodPrefab;
    public GameObject currentFood;
    public Vector3 curPos;
    // Start is called before the first frame update
    void Addnewfood()
    {
        RandomPosition();
        currentFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;
    }
    void RandomPosition()
    {
        curPos = new Vector3(Random.Range(xSize*-1, xSize), 0.18f, Random.Range(zSize*-1, zSize));
    }

    // Update is called once per frame
    void Update()
    {
        if(!currentFood)
        {
            Addnewfood();
        }
        else
        {
            return;
        }
    }
}
