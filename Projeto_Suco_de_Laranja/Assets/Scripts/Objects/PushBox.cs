using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour
{
    public float distance = 0.5f;

    public void Push()
    {
        gameObject.transform.Translate(distance * -1, 0, 0);
    }
}
