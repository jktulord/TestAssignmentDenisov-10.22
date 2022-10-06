using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public CoinCounter coinCounter;
    public static WinManager self;

    public GameObject VictoryPanel; 
    public GameObject DefeatPanel;
    // Start is called before the first frame update
    void Start()
    {
        self = this;
    }

    public static void PlayerDeath(){
        self.DefeatPanel.SetActive(true);
        self.coinCounter.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (coinCounter.value >= 50){
            VictoryPanel.SetActive(true);
            coinCounter.gameObject.SetActive(false);
        }    
    }

    public void Reset(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
