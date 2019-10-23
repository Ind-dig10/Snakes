using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class SnakeMove : MonoBehaviour
{
    public float speed;
    public float Rotationspeed;
    public int size = 0;
    public float z_offset = -0.5f;
    public List<GameObject> tallobject = new List<GameObject>();
    public Text scoretext;
    public int score = 0;
    public GameObject Tailprefab;

    // Start is called before the first frame update
    void Start()
    {
        tallobject.Add(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = score.ToString();
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up*Rotationspeed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up*-1 * Rotationspeed * Time.deltaTime);
        }
    }

    public void AddNewTale()
    {

        score++;
        Vector3 newTailpos = tallobject[tallobject.Count-1].transform.position;
        newTailpos.z -= z_offset;
        tallobject.Add(GameObject.Instantiate(Tailprefab, newTailpos, Quaternion.identity) as GameObject);
    }
}
