using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    private TMP_Text Text;
    public int value;

    private static CoinCounter self; 
    // Start is called before the first frame update
    void Start()
    {
        self = this;
        Text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Coins:"+value;
    }

    public static void addCoin(){
        self.value++;
    }
}
