using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] GameObject[] itemPrefab = null;
    public bool stopflg;
    int number;
    bool startflg;
    int Hitcount;

    float speed = -2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (startflg)
        {
            if (!stopflg)
            {
                transform.Rotate(new Vector3(0.0f, 0, speed));

            }
        }

    }


    public void stopGame()
    {
        Debug.Log(Hitcount);
        Hitcount++;
        if (Hitcount >= 3)
        {
            stopflg = true;
            CreateItem();
        }
    }

    public void StartGame()
    {
        startflg = true;
    }

    void CreateItem()
    {
        number = UnityEngine.Random.Range(0, itemPrefab.Length);
        Instantiate(itemPrefab[number]);
    }
}
