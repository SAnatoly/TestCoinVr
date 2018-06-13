using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour, IVr
{
    public void OnReady()
    {
        Destroy(gameObject);
    }
}
