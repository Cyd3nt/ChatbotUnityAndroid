using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChatUI : MonoBehaviour
{
    public static ChatUI Instance { get; private set; }
    [SerializeField] AIMLTestChat aimlChat;

    [SerializeField] Button userSend;
    //[SerializeField] TextMeshProUGUI userInput;
    [SerializeField] InputField userInput;
    [SerializeField] Text botText;
    [SerializeField] ScriptableViToEn vte;
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
        Debug.Log("msg:" + msg);
        userInput.text = "";
        // vte.viToEn
        foreach (var item in vte.viToEn)
        {
            if (item.IsVietnamese(msg)) {
                Debug.Log("input is vietnamese:" + msg);
                msg = item.GetEnglishKey();
            }
        }

        botAnswer = aimlChat.UserSend(msg);
        BotTextSet(botAnswer);
    }
}
