using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    Button startGameButton;
    Button quitGameButton;

    // Start is called before the first frame update
    void Start()
    {
        startGameButton = GameObject.Find("Start Game Button").GetComponent<Button>();
        quitGameButton = GameObject.Find("Quit Game Button").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnClick() 
    {

    }

    public void StartGame() {
        Debug.Log("Started");
    }
}
