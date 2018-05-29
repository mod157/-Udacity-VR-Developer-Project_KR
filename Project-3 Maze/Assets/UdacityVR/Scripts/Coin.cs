using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinPoof;

    public void OnCoinClicked() {
        Instantiate(coinPoof, gameObject.transform);
        Destroy(gameObject, 2f);
    }

}
