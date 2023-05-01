using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public GameObject note1Text;

   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            note1Text.SetActive(true);
            
        }

        if (Input.GetKeyDown("E"))
        {
            note1Text.SetActive(false);
        }
            

    }
        private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            note1Text.SetActive(true);

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        note1Text.SetActive(false);
    }

   
 
}
