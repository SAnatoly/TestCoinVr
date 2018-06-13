using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IVr
{
    public void OnReady()
    {
        GameController.instance.ChangeScore(1);
        Destroy(gameObject);
    }
}
