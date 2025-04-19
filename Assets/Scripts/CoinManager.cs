using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coinCount;
    public TMP_Text coinText;
    public GameObject door;
    public GameObject doorto2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = ": " + coinCount.ToString();

        if(coinCount == 4)
        {
            Destroy(door);
        }

        if(coinCount == 10)
        {
            Destroy(doorto2);
        }
    }

}
