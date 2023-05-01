using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int notes = 0;
    private int matches = 0;
    private int keys = 0;

    [SerializeField] private Text notesText;
    [SerializeField] private Text matchesText;
    [SerializeField] private Text keysText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.CompareTag("note"))
        {
            Destroy(collision.gameObject);
            notes++;
            notesText.text = notes + " /3";
        }

        if (collision.gameObject.CompareTag("matches"))
        {
            Destroy(collision.gameObject);
            matches++;
            matchesText.text = matches + " /3";
        }

        if (collision.gameObject.CompareTag("key"))
        {
            Destroy(collision.gameObject);
            keys++;
            keysText.text = "x " + keys;
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
}
