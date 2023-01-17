using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopClothesTrigger : MonoBehaviour
{
    public static bool topClothesTrigger;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            topClothesTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            topClothesTrigger = false;
        }
    }
}
