using UnityEngine;
using System.Collections;
using System;
using Chatbot;

/// <summary>
/// Helperfunction, to perform facial expressions, currently realized with 
/// emoticons.
/// </summary>
[AddComponentMenu("Chatbot/Helperfunctions/MotiveFacialExpression")]
public class MotiveFacialExpression : MonoBehaviour {
	// Gameobject with attatched ChatbotCore script
	private GameObject bot;
	// Enabled emoticon path
	public string EmoticonPath;
	// Default emoticon path
	public string defaultEmoticonPath;
	// Seconds to wait before send Finish event
	public float WaitSeconds;

	/// <summary>
	/// Initialie this instance. Retrieves Chatbot.Core instance.
	/// </summary>
	void Start () {
		// Counter to avoid endless loop
		int counter = 0;
		// Count till this value
		int countmax = 10;
		// Current transform
		Transform tmpTrans = this.transform;
		// Gathered ChatbotCore component
		ChatbotCore tmpChatbotCore=null;
		// Loop through transforms till counter reached countmax
		while(counter < countmax) {
			// Is Transform available?
			if(tmpTrans==null)
				// Abort global settings update
				counter=countmax;
			else {
				// Try to grab ChatbotCore component
				tmpChatbotCore = tmpTrans.gameObject.GetComponent<ChatbotCore>();
				// Test wether tmpChatbotCore exists
				if(tmpChatbotCore!=null) {
					// Set bot gameobject
					bot=tmpChatbotCore.gameObject;
					// Abort loop
					counter=countmax;
				}
				// Get parent transform
				tmpTrans = tmpTrans.parent;
				// Increase counter
				counter++;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Coroutine called by Trigger
	/// </summary>


	/// <summary>
	/// Trigger this instance.
	/// </summary>
	void Trigger() {
		// Start coroutine
		StartCoroutine("Wait");
	}
}
