using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "point")
        {
            GameObject obj = GameObject.Find("rebar");
            obj.GetComponent<Rotation>().stopGame();
        }
    }
}
