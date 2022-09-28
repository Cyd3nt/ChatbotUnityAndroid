using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatUI : MonoBehaviour
{
    public static ChatUI Instance { get; private set; }
    [SerializeField] AIMLTestChat aimlChat;

    [SerializeField] Button userSend;
    [SerializeField] Text userInput;
    [SerializeField] Text botText;
    string botAnswer;

    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotTextSet(string str) {
        botText.text = str;
    }
    public void __UserSendMsg() {
        string msg = userInput.text;
        userInput.text = "";
        botAnswer = aimlChat.UserSend(msg);
        BotTextSet(botAnswer);
    }
}
