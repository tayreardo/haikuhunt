using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    //UI References
    [SerializeField]
    private TMP_Text itemText;

    [SerializeField]
    private TMP_Text haikuText;

    [SerializeField]
    private Image portraitImage;


    //Dialogue Content
    [SerializeField]
    private string[] item;
    
    [SerializeField]
    [TextArea]
    private string[] haiku;

    [SerializeField]
    private Sprite[] portrait;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
