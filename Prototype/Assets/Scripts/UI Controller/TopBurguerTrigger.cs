using UnityEngine;

public class TopBurguerTrigger : MonoBehaviour
{
    public static bool topBurguerTrigger;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            topBurguerTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            topBurguerTrigger = false;
        }
    }
}
