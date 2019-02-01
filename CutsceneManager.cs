using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneManager : MonoBehaviour
{
    public GameObject motherSpeech;
    public GameObject sonSpeech;

    private bool Switch;

    private string string1;
    private string string2;
    private string string3;
    private string string4;
    private string string5;
    private string string6;
    private string string7;
    private string string8;
    private string string9;
    private string string10;
    private string string11;
    private string string12;
    private string string13;
    private string string14;

    // Start is called before the first frame update
    void Start()
    {
        Switch = true;
        string1 = "James?";
        string2 = "James.";
        string3 = "James!";
        string4 = "What!?";
        string5 = "Can you take out the trash and empty the dishwasher?";
        string6 = "Later.";
        string7 = "You've been on your game all day, you can do it now.";
        string8 = "Yor're always nagging me.";
        string9 = "I'm sorry, but you live here and have responsibilities other than eating, sleeping, going to school and video games.";
        string10 = "I don't even want to do this...";
        string11 = "Fine! Then I'll say no to everything you ask me for.";
        string12 = "I'm not doing these and I'm going back upstairs.";
        string13 = "James, I've asked you to do some things around the house. Do them now!";
        string14 = "I wish you would just die and leave me alone.";

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.C) && Switch)
        {
            SpeechBubble(motherSpeech, string2);
            RemoveSpeech(sonSpeech);
            Switch = false;
            Debug.Log("speech up");
        }

        if (Input.GetKeyDown(KeyCode.V) && !Switch)
        {

            SpeechBubble(sonSpeech, string4);
            RemoveSpeech(motherSpeech);
            Switch = true;
            Debug.Log("speech down");
        }

    }
    

    public void SpeechBubble(GameObject go, string str)
    {
        go.GetComponentInChildren<Text>().text = str;
        go.gameObject.SetActive(true);
    }

    public void RemoveSpeech(GameObject go)
    {
        go.gameObject.SetActive(false);
    }
}
