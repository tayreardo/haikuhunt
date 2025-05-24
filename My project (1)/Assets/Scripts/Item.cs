using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField]
    private string itemName;

    [SerializeField]
    private int quantity;

    [SerializeField]
    private Sprite sprite;

    private InventoryManager inventoryManager;

    //UI References
   [SerializeField]
    private GameObject dialogueCanvas;
   
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

    private bool dialogueActivated;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            
            dialogueCanvas.SetActive(true);
            itemText.text = item[0];
            haikuText.text = haiku[0];
            portraitImage.sprite = portrait[0];

            inventoryManager.AddItem(itemName, quantity, sprite);
            Destroy(gameObject);
        
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            dialogueActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogueActivated = false;
        dialogueCanvas.SetActive(false);
    }

}
