using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinManager : MonoBehaviour
{
    public int coinCount;
    public Text CoinText;
    public GameObject door;
    private bool doorDestroyed;
    // Start is called before the first frame update
    void Start()
    { 

    }

// Update is called once per frame
    void Update()
    {
        CoinText.text = coinCount.ToString();

        if (coinCount == 6 && !doorDestroyed)
        {
            doorDestroyed = true;
            Destroy(door);
        }
    }
}
