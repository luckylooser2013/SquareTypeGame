using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.EventSystems;
public class InkManager : MonoBehaviour
{
    // Unity variables.
    public GameObject panel;
    public bool isDialoguePlaying;
    public bool canContinue;
    public TextMeshProUGUI dialoguePanel;
    public GameObject[] choices;
    public TMPro.TextMeshProUGUI choicesText;

    // Ink variables.
    public Story story;
    public TextAsset InkStory;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
